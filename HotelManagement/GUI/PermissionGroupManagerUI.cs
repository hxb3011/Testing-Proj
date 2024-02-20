namespace HotelManagement.GUI
{
    using HotelManagement.Business;
    using HotelManagement.Data;
    using HotelManagement.Data.Transfer;
    using HotelManagement.Presentation.ListControlHelpers;
    using HotelManagement.Properties;

    using MaterialSkin;

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class PermissionGroupManagerUI : Form
    {
        private bool editing, searching;
        private int selectedIndex;
        Bitmap defLogo;
        Material2ItemRenderer<ListBox> lbPermissionGroupRenderer;

        public PermissionGroupManagerUI()
        {
            InitializeComponent();
            defLogo = new Bitmap(Resources.key_outline);
            defLogo.SetResolution(40, 40);
            lbPermissionGroupRenderer = new Material2ItemRenderer<ListBox>.Simple(lbGroups, OnFillItem)
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
            lbGroups.IntegralHeight = false;
            lbGroups.ItemHeight = 72;
            MinimumSize = new Size(360 + SystemInformation.VerticalScrollBarWidth, 360 + SystemInformation.HorizontalScrollBarHeight);
            ClientSize = new Size(600, 600);
            selectedIndex = -1;
        }

        private void OnFillItem(ListBox c, int itemIndex, DrawItemState state, ref string title, ref string subtitle, ref string subtitle2, ref Image logo, ref bool action)
        {
            var a = c.Items[itemIndex] as PermissionGroup;
            title = a.Name;
            subtitle = a.IdString();
            logo = defLogo;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var gbo = GrantingPermissionsBO.Instance;
            var mbo = PermissionGroupManagerBO.Instance;
            gbo.SelectedAccessable = mbo.SelectedGroup;
            gbo.Editing = editing;

            LoadGroups();
            AdjustSelectedIndex();
            LoadActions();
            LoadInfo();
            OnResize(EventArgs.Empty);
        }

        private void LoadGroups()
        {
            lbGroups.DataSource = null;
            lbGroups.DataSource = PermissionGroupManagerBO.Instance.PermissionGroups;
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
                    bool write = LoginBO.IsPermissionGranted(Permission.WritePermissionGroup);
                    if (selectedIndex >= 0)
                    {
                        btnAdd.Available = write
                            && ClientSize.Width >= 600;
                        btnEdit.Available = write;
                        btnDelete.Available = write
                            && PermissionGroupManagerBO.Instance.CanDelete;
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
                || PermissionGroupManagerBO.Instance.SelectedGroup != null)
            {
                pnGroupInfo.Visible = true;
                ucGroupInfo.LoadGroup();
                ucGroupInfo.Editing = editing;
                ucGranting.LoadPermissions();
                ucGranting.Editing = editing;
            }
            else pnGroupInfo.Visible = false;
        }

        private void AdjustSelectedIndex()
        {
            var sel = -1;
            var bo = PermissionGroupManagerBO.Instance;
            var groups = bo.PermissionGroups;
            for (int i = 0, c = groups.Count; i < c; ++i)
            {
                if (groups[i] == bo.SelectedGroup)
                {
                    sel = i;
                    break;
                }
            }
            selectedIndex = sel;
            lbGroups.SelectedIndex = sel;
        }

        private void OnSelectedGroupIndex(object sender, EventArgs args)
        {
            var bo = PermissionGroupManagerBO.Instance;
            if (editing)
            {
                bo.CancelEdit();
                editing = false;
            }
            selectedIndex = lbGroups.SelectedIndex;
            var items = lbGroups.Items;
            var pg = (uint)selectedIndex < (uint)items.Count ? items[selectedIndex] as PermissionGroup : null;
            bo.SelectedGroup = pg;
            GrantingPermissionsBO.Instance
                .SelectedAccessable = pg;
            LoadActions();
            LoadInfo();
        }

        private void OnBack(object sender, EventArgs e)
        {
            var bo = PermissionGroupManagerBO.Instance;
            if (searching)
            {
                tbSearchBox.Text = string.Empty;
                bo.Searching = false;
                searching = false;
                LoadGroups();
                AdjustSelectedIndex();
            }
            else if (editing)
            {
                editing = false;
                bo.CancelEdit();
                if (selectedIndex >= 0)
                {
                    var pg = bo.PermissionGroups[selectedIndex];
                    bo.SelectedGroup = pg;
                    GrantingPermissionsBO.Instance
                        .SelectedAccessable = pg;
                }
            }
            else if (ClientSize.Width < 600 && selectedIndex >= 0)
            {
                selectedIndex = -1;
                lbGroups.SelectedIndex = -1;
                bo.SelectedGroup = null;
                GrantingPermissionsBO.Instance
                    .SelectedAccessable = null;
            }
            else return;
            LoadActions();
            LoadInfo();
        }

        private void OnSave(object sender, EventArgs e)
        {
            var bo = PermissionGroupManagerBO.Instance;
            if ((selectedIndex >= 0 || bo.SelectedGroup != null)
                && ucGroupInfo.CanSaveGroup())
            {
                ucGroupInfo.SaveGroup();
                ucGranting.SaveChange();
                bo.AcceptEdit();
                editing = false;
                LoadGroups();
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
            PermissionGroupManagerBO.Instance.Searching = true;
            searching = true;
            LoadGroups();
            AdjustSelectedIndex();
            LoadActions();
        }

        private void OnLookingUp(object sender, EventArgs e)
        {
            var bo = PermissionGroupManagerBO.Instance;
            bo.LookupGroup(tbSearchBox.Text);
            LoadGroups();
            AdjustSelectedIndex();
            LoadActions();
            LoadInfo();
        }

        private void OnAdding(object sender, EventArgs e)
        {
            var bo = PermissionGroupManagerBO.Instance;
            bo.CreateGroup();
            GrantingPermissionsBO.Instance
                .SelectedAccessable = bo.SelectedGroup;
            editing = true;
            LoadActions();
            LoadInfo();
        }

        private void OnEditing(object sender, EventArgs e)
        {
            var bo = PermissionGroupManagerBO.Instance;
            var pg = bo.PermissionGroups[selectedIndex];
            bo.SelectedGroup = pg;
            GrantingPermissionsBO.Instance
                .SelectedAccessable = pg;
            editing = true;
            LoadActions();
            LoadInfo();
        }

        private void OnDeleting(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhóm quyền này không?", "Xóa nhóm quyền",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                PermissionGroupManagerBO.Instance.DeleteGroup();
                GrantingPermissionsBO.Instance.SelectedAccessable = null;
                selectedIndex = -1;
                editing = false;
                LoadGroups();
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
            if (pnGroupInfo.VerticalScroll.Visible)
                scrollSize.Width = SystemInformation.VerticalScrollBarWidth;
            if (pnGroupInfo.HorizontalScroll.Visible)
                scrollSize.Height = SystemInformation.HorizontalScrollBarHeight;
            int width = s.Width;
            if (width >= 600)
            {
                s.Width = (int)(width * 0.4);
                lbGroups.ClientSize = s;
                pnGroupInfo.Location = new(s.Width, 0);
                s.Width = width - s.Width;
            }
            else
            {
                lbGroups.ClientSize = s;
                pnGroupInfo.Location = new(0, 0);
            }
            pnGroupInfo.ClientSize = s;
            s -= scrollSize;
            ucGroupInfo.ClientSize = new(s.Width, ucGroupInfo.ClientSize.Height);
            ucGranting.ClientSize = new(s.Width, 0);
            pnGroupInfo.AutoScrollMinSize = s;
        }
    }
}
