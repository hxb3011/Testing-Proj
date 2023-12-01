﻿namespace HotelManagement.GUI
{
    using HotelManagement.Business;
    using HotelManagement.Data;
    using HotelManagement.Data.Transfer;

    using MaterialSkin;

    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class StaffManagerUI : Form
    {
        private bool editing, searching;
        private int selectedIndex;
        public StaffManagerUI()
        {
            InitializeComponent();
            ucStaffInfo.PermissionsInfoChanged += OnPermissionsInfoChanged;
            MinimumSize = new Size(360 + SystemInformation.VerticalScrollBarWidth, 360 + SystemInformation.HorizontalScrollBarHeight);
            ClientSize = new Size(600, 600);
            selectedIndex = -1;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var gbo = GrantingPermissionsBO.Instance;
            var mbo = StaffManagerBO.Instance;
            gbo.SelectedAccessable = mbo.SelectedStaff;
            gbo.Editing = editing;

            LoadStaffs();
            AdjustSelectedIndex();
            LoadActions();
            LoadInfo();
            OnResize(EventArgs.Empty);
        }

        private void OnPermissionsInfoChanged(object? sender, EventArgs e) => ucGranting.LoadPermissions();

        private void LoadStaffs()
        {
            lbStaffs.Clear();
            foreach (var staff in StaffManagerBO.Instance.Staffs)
            {
                lbStaffs.AddItem(new MaterialListBoxItem()
                {
                    Tag = staff,
                    Text = staff.FullName,
                    SecondaryText = staff.IdString()
                });
            }
        }

        private void LoadActions()
        {
            dbtnRoleManager.Available = LoginBO.IsPermissionGranted(Permission.ReadRole);
            dbtnSave.Available = false;
            dbtnAdd.Available = false;
            dbtnEdit.Available = false;
            dbtnDelete.Available = false;
            if (!searching)
            {
                if (!editing)
                {
                    bool write = LoginBO.IsPermissionGranted(Permission.WriteStaff);
                    if (selectedIndex >= 0)
                    {
                        dbtnAdd.Available = write
                            && ClientSize.Width >= 600;
                        dbtnEdit.Available = write;
                        dbtnDelete.Available = write
                            && StaffManagerBO.Instance.CanDelete;
                    }
                    else dbtnAdd.Available = write;
                }
                else dbtnSave.Available = true;
            }
            AdjustToolbar();
        }

        private void LoadInfo()
        {
            if (selectedIndex >= 0
                || StaffManagerBO.Instance.SelectedStaff != null)
            {
                pnStaffInfo.Visible = true;
                ucStaffInfo.LoadStaff();
                ucStaffInfo.Editing = editing;
                ucGranting.LoadPermissions();
                ucGranting.Editing = editing;
            }
            else pnStaffInfo.Visible = false;
        }

        private void AdjustSelectedIndex()
        {
            var sel = -1;
            var bo = StaffManagerBO.Instance;
            var staffs = bo.Staffs;
            for (int i = 0, c = staffs.Count; i < c; ++i)
            {
                if (staffs[i] == bo.SelectedStaff)
                {
                    sel = i;
                    break;
                }
            }
            selectedIndex = sel;
            lbStaffs.SelectedIndex = sel;
        }

        private void OnSelectedStaffIndex(object sender, MaterialListBoxItem selectedItem)
        {
            var bo = StaffManagerBO.Instance;
            if (editing)
            {
                bo.CancelEdit();
                editing = false;
            }
            selectedIndex = lbStaffs.SelectedIndex;
            var sa = (Staff?)selectedItem.Tag;
            bo.SelectedStaff = sa;
            GrantingPermissionsBO.Instance
                .SelectedAccessable = sa;
            LoadActions();
            LoadInfo();
        }

        private void OnBack(object sender, EventArgs e)
        {
            var bo = StaffManagerBO.Instance;
            if (searching)
            {
                tbSearchBox.Text = string.Empty;
                bo.Searching = false;
                searching = false;
                LoadStaffs();
                AdjustSelectedIndex();
            }
            else if (editing)
            {
                editing = false;
                bo.CancelEdit();
                if (selectedIndex >= 0)
                {
                    var sa = bo.Staffs[selectedIndex];
                    bo.SelectedStaff = sa;
                    GrantingPermissionsBO.Instance
                        .SelectedAccessable = sa;
                }
            }
            else if (ClientSize.Width < 600 && selectedIndex >= 0)
            {
                selectedIndex = -1;
                lbStaffs.SelectedIndex = -1;
                bo.SelectedStaff = null;
                GrantingPermissionsBO.Instance
                    .SelectedAccessable = null;
            }
            else return;
            LoadActions();
            LoadInfo();
        }

        private void OnSave(object sender, EventArgs e)
        {
            var bo = StaffManagerBO.Instance;
            if ((selectedIndex >= 0 || bo.SelectedStaff != null)
                && ucStaffInfo.CanSaveStaff())
            {
                ucStaffInfo.SaveStaff();
                ucGranting.SaveChange();
                bo.AcceptEdit();
                editing = false;
                LoadStaffs();
                AdjustSelectedIndex();
                LoadActions();
            }
            else
            {
                MessageBox.Show("Tên nhân viên không hợp lệ!",
                    "Lưu nhân viên", MessageBoxButtons.OK);
            }
        }

        private void OnStartSearch(object sender, EventArgs e)
        {
            StaffManagerBO.Instance.Searching = true;
            searching = true;
            LoadStaffs();
            AdjustSelectedIndex();
            LoadActions();
        }

        private void OnLookingUp(object sender, EventArgs e)
        {
            var bo = StaffManagerBO.Instance;
            bo.LookupStaff(tbSearchBox.Text);
            LoadStaffs();
            AdjustSelectedIndex();
            LoadActions();
            LoadInfo();
        }

        private void OnAdding(object sender, EventArgs e)
        {
            var bo = StaffManagerBO.Instance;
            bo.CreateStaff();
            GrantingPermissionsBO.Instance
                .SelectedAccessable = bo.SelectedStaff;
            editing = true;
            LoadActions();
            LoadInfo();
        }

        private void OnEditing(object sender, EventArgs e)
        {
            var bo = StaffManagerBO.Instance;
            var pg = bo.Staffs[selectedIndex];
            bo.SelectedStaff = pg;
            GrantingPermissionsBO.Instance
                .SelectedAccessable = pg;
            editing = true;
            LoadActions();
            LoadInfo();
        }

        private void OnDeleting(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Xóa nhân viên",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                StaffManagerBO.Instance.DeleteStaff();
                GrantingPermissionsBO.Instance.SelectedAccessable = null;
                selectedIndex = -1;
                editing = false;
                LoadStaffs();
                LoadActions();
                LoadInfo();
            }
        }

        private void OnStartImex(object sender, EventArgs e)
            => new StaffImexUI()
            {
                StartPosition = FormStartPosition.CenterScreen
            }.ShowDialog();

        private void OnStartRoleManager(object sender, EventArgs e)
            => new RoleManagementUI()
            {
                StartPosition = FormStartPosition.CenterScreen
            }.ShowDialog();

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
            dbtnSearch.Available = false;
            if (!searching)
            {
                width -= btnSearch.Width;
                btnSearch.Available = true;
            }
            else btnSearch.Available = false;

            var list = btnMore.DropDownItems;
            for (int i = 0, c = list.Count; i < c; ++i)
            {
                if (list[i].Available)
                {
                    btnMore.Available = true;
                    if (!searching && width < btnSearch.Width)
                    {
                        btnSearch.Available = false;
                        dbtnSearch.Available = true;
                    }
                    else width -= btnMore.Width;
                    return;
                }
            }
            btnMore.Available = false;
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
            if (pnStaffInfo.VerticalScroll.Visible)
                scrollSize.Width = SystemInformation.VerticalScrollBarWidth;
            if (pnStaffInfo.HorizontalScroll.Visible)
                scrollSize.Height = SystemInformation.HorizontalScrollBarHeight;
            int width = s.Width;
            if (width >= 600)
            {
                s.Width = (int)(width * 0.4);
                lbStaffs.ClientSize = s;
                pnStaffInfo.Location = new(s.Width, 0);
                s.Width = width - s.Width;
            }
            else
            {
                lbStaffs.ClientSize = s;
                pnStaffInfo.Location = new(0, 0);
            }
            pnStaffInfo.ClientSize = s;
            s -= scrollSize;
            ucStaffInfo.ClientSize = new(s.Width, ucStaffInfo.ClientSize.Height);
            ucGranting.ClientSize = new(s.Width, 0);
            pnStaffInfo.AutoScrollMinSize = s;
        }
    }
}
