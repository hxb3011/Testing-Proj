namespace HotelManagement.GUI
{
    using HotelManagement.Business;
    using HotelManagement.Data;
    using HotelManagement.Data.Transfer;
    using HotelManagement.Presentation.ListControlHelpers;
    using HotelManagement.Properties;

    using MaterialSkin;

    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class RoleManagementUI : Form
    {
        private bool editing, searching;
        private int selectedIndex;
        Bitmap defLogo;
        Material2ItemRenderer<ListBox> lbRoleRenderer;
        public RoleManagementUI()
        {
            InitializeComponent();
            defLogo = new Bitmap(Resources.briefcase_outline);
            defLogo.SetResolution(40, 40);
            lbRoleRenderer = new Material2ItemRenderer<ListBox>.Simple(lbRoles, OnFillItem)
            {
                BackgroundBrushes =
                {
                    { DrawItemState.Selected, new SolidBrush(Color.Gainsboro) },
                    { DrawItemState.None, new SolidBrush(Color.WhiteSmoke) }
                },
                TitleBrushes =
                {
                    { DrawItemState.None, new SolidBrush(Color.Black) }
                },
                SubtitleBrushes =
                {
                    { DrawItemState.None, new SolidBrush(Color.DimGray) }
                }
            };
            lbRoles.IntegralHeight = false;
            lbRoles.ItemHeight = 72;
            MinimumSize = new Size(360 + SystemInformation.VerticalScrollBarWidth, 360 + SystemInformation.HorizontalScrollBarHeight);
            ClientSize = new Size(600, 600);
            selectedIndex = -1;
        }

        private void OnFillItem(ListBox c, int itemIndex, DrawItemState state, ref string title, ref string subtitle, ref string subtitle2, ref Image logo, ref bool action)
        {
            var a = c.Items[itemIndex] as Role;
            title = a.Name;
            subtitle = a.IdString();
            logo = defLogo;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadRoles();
            AdjustSelectedIndex();
            LoadActions();
            LoadInfo();
            OnResize(EventArgs.Empty);
        }

        private void LoadRoles()
        {
            lbRoles.DataSource = null;
            lbRoles.DataSource = RoleManagerBO.Instance.Roles;
            //lbRoles.Clear();
            //foreach (var group in RoleManagerBO.Instance.Roles)
            //{
            //    lbRoles.AddItem(new MaterialListBoxItem()
            //    {
            //        Tag = group,
            //        Text = group.Name,
            //        SecondaryText = group.IdString()
            //    });
            //}
        }

        private void LoadActions()
        {
            btnSave.Available = false;
            btnAdd.Available = false;
            btnEdit.Available = false;
            btnDelete.Available = false;
            if (!searching)
            {
                if (!editing)
                {
                    bool write = LoginBO.IsPermissionGranted(Permission.WriteRole);
                    if (selectedIndex >= 0)
                    {
                        btnAdd.Available = write
                            && ClientSize.Width >= 600;
                        btnEdit.Available = write;
                        btnDelete.Available = write
                            && RoleManagerBO.Instance.CanDelete;
                    }
                    else btnAdd.Available = write;
                }
                else btnSave.Available = true;
            }
            AdjustToolbar();
        }

        private void LoadInfo()
        {
            if (selectedIndex >= 0
                || RoleManagerBO.Instance.SelectedRole != null)
            {
                pnRoleInfo.Visible = true;
                ucRoleInfo.LoadRole();
                ucRoleInfo.Editing = editing;
            }
            else pnRoleInfo.Visible = false;
        }

        private void AdjustSelectedIndex()
        {
            var sel = -1;
            var bo = RoleManagerBO.Instance;
            var groups = bo.Roles;
            for (int i = 0, c = groups.Count; i < c; ++i)
            {
                if (groups[i] == bo.SelectedRole)
                {
                    sel = i;
                    break;
                }
            }
            selectedIndex = sel;
            lbRoles.SelectedIndex = sel;
        }

        private void OnSelectedRoleIndex(object sender, EventArgs args)
        {
            var bo = RoleManagerBO.Instance;
            if (editing)
            {
                bo.CancelEdit();
                editing = false;
            }
            selectedIndex = lbRoles.SelectedIndex;
            var items = lbRoles.Items;
            var ro = (uint)selectedIndex < (uint)items.Count ? items[selectedIndex] as Role : null;
            bo.SelectedRole = ro;
            LoadActions();
            LoadInfo();
        }

        private void OnBack(object sender, EventArgs e)
        {
            var bo = RoleManagerBO.Instance;
            if (searching)
            {
                tbSearchBox.Text = string.Empty;
                bo.Searching = false;
                searching = false;
                LoadRoles();
                AdjustSelectedIndex();
            }
            else if (editing)
            {
                editing = false;
                bo.CancelEdit();
                if (selectedIndex >= 0)
                {
                    var pg = bo.Roles[selectedIndex];
                    bo.SelectedRole = pg;
                }
            }
            else if (ClientSize.Width < 600 && selectedIndex >= 0)
            {
                selectedIndex = -1;
                lbRoles.SelectedIndex = -1;
                bo.SelectedRole = null;
            }
            else return;
            LoadActions();
            LoadInfo();
        }

        private void OnSave(object sender, EventArgs e)
        {
            var bo = RoleManagerBO.Instance;
            if ((selectedIndex >= 0 || bo.SelectedRole != null)
                && ucRoleInfo.CanSaveRole())
            {
                ucRoleInfo.SaveRole();
                bo.AcceptEdit();
                editing = false;
                LoadRoles();
                AdjustSelectedIndex();
                LoadActions();
            }
            else
            {
                MessageBox.Show("Tên nhóm quyền không hợp lệ!",
                    "Lưu nhóm quyền", MessageBoxButtons.OK);
            }
        }

        private void OnStartSearch(object sender, EventArgs e)
        {
            RoleManagerBO.Instance.Searching = true;
            searching = true;
            LoadRoles();
            AdjustSelectedIndex();
            LoadActions();
        }

        private void OnLookingUp(object sender, EventArgs e)
        {
            var bo = RoleManagerBO.Instance;
            bo.LookupRole(tbSearchBox.Text);
            LoadRoles();
            AdjustSelectedIndex();
            LoadActions();
            LoadInfo();
        }

        private void OnAdding(object sender, EventArgs e)
        {
            var bo = RoleManagerBO.Instance;
            bo.CreateRole();
            editing = true;
            LoadActions();
            LoadInfo();
        }

        private void OnEditing(object sender, EventArgs e)
        {
            var bo = RoleManagerBO.Instance;
            bo.SelectedRole = bo.Roles[selectedIndex];
            editing = true;
            LoadActions();
            LoadInfo();
        }

        private void OnDeleting(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhóm quyền này không?", "Xóa nhóm quyền",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                RoleManagerBO.Instance.DeleteRole();
                selectedIndex = -1;
                editing = false;
                LoadRoles();
                LoadActions();
                LoadInfo();
            }
        }

        private int AdjustBackButtonSize()
        {
            int consumed = 0;
            if (editing || searching || ClientSize.Width < 600 && selectedIndex >= 0)
            {
                consumed += btnBack.Width;
                btnBack.Available = true;
            }
            else btnBack.Available = false;
            return consumed;
        }

        private void AdjustOptions(ref int width)
        {
            btnSearch.Available = false;
            if (!searching)
            {
                width -= btnSearch.Width;
                btnSearch.Available = true;
            }
            else btnSearch.Available = false;

            //var list = btnMore.DropDownItems;
            //for (int i = 0, c = list.Count; i < c; ++i)
            //{
            //    if (list[i].Available)
            //    {
            //        btnMore.Available = true;
            //        if (!searching && width < btnSearch.Width)
            //        {
            //            btnSearch.Available = false;
            //            btnSearch.Available = true;
            //        }
            //        else width -= btnMore.Width;
            //        return;
            //    }
            //}
            //btnMore.Available = false;
        }

        private void AdjustToolbar()
        {
            var s = ClientSize;
            var width = s.Width - AdjustBackButtonSize();
            if (searching)
            {
                tbSearchBox.Available = true;
                tbSearchBox.Focus();
                width -= tbSearchBox.Width;
            }
            else tbSearchBox.Available = false;

            if (s.Width >= 600 || !searching)
            {
                txtTitle.Available = true;
                width -= txtTitle.Width;
            }
            else txtTitle.Visible = false;

            AdjustOptions(ref width);

            if (searching)
            {
                Padding p = tbSearchBox.Margin;
                p.Left = width / 2;
                tbSearchBox.Margin = p;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustToolbar();
            Size s = ClientSize, scrollSize = new(0, 0);
            s.Height -= 56;
            if (pnRoleInfo.VerticalScroll.Visible)
                scrollSize.Width = SystemInformation.VerticalScrollBarWidth;
            if (pnRoleInfo.HorizontalScroll.Visible)
                scrollSize.Height = SystemInformation.HorizontalScrollBarHeight;
            int width = s.Width;
            if (width >= 600)
            {
                s.Width = (int)(width * 0.4);
                lbRoles.ClientSize = s;
                pnRoleInfo.Location = new(s.Width, 0);
                s.Width = width - s.Width;
            }
            else
            {
                lbRoles.ClientSize = s;
                pnRoleInfo.Location = new(0, 0);
            }
            pnRoleInfo.ClientSize = s;
            s -= scrollSize;
            ucRoleInfo.ClientSize = new(s.Width, ucRoleInfo.ClientSize.Height);
            pnRoleInfo.AutoScrollMinSize = s;
        }
    }
}
