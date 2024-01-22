namespace HotelManagement.GUI
{
    using HotelManagement.Business;
    using HotelManagement.Data;
    using HotelManagement.Data.Transfer;

    using MaterialSkin;

    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class AccountManagerUI : Form
    {
        private bool editing, searching;
        private int selectedIndex;
        public AccountManagerUI()
        {
            InitializeComponent();
            MinimumSize = new Size(360 + SystemInformation.VerticalScrollBarWidth, 360 + SystemInformation.HorizontalScrollBarHeight);
            ClientSize = new Size(600, 600);
            selectedIndex = -1;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadAccounts();
            AdjustSelectedIndex();
            LoadActions();
            LoadInfo();
        }

        private void LoadAccounts()
        {
            lbAccounts.Clear();
            foreach (var account in AccountManagerBO.Instance.Accounts)
            {
                lbAccounts.AddItem(new MaterialListBoxItem()
                {
                    Tag = account,
                    Text = account.UserName,
                    SecondaryText = "UID " + account.UidString()
                });
            }
        }

        private void LoadActions()
        {
            dbtnGroups.Available = LoginBO.IsPermissionGranted(Permission.ReadPermissionGroup);
            dbtnSave.Available = false;
            dbtnAdd.Available = false;
            dbtnEdit.Available = false;
            dbtnDelete.Available = false;
            if (!searching)
            {
                if (!editing)
                {
                    bool write = LoginBO.IsPermissionGranted(Permission.WriteAccount);
                    if (selectedIndex >= 0)
                    {
                        dbtnAdd.Available = write
                            && ClientSize.Width >= 600;
                        dbtnEdit.Available = write;
                        dbtnDelete.Available = write
                            && AccountManagerBO.Instance.CanDelete;
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
                || AccountManagerBO.Instance.SelectedAccount != null)
            {
                lbAccounts.Visible = ClientSize.Width >= 600;
                pnAccountInfo.Visible = true;
                ucAccountInfo.LoadAccount();
                ucAccountInfo.Editing = editing;
            }
            else
            {
                lbAccounts.Visible = true;
                pnAccountInfo.Visible = false;
            }
        }

        private void AdjustSelectedIndex()
        {
            var sel = -1;
            var bo = AccountManagerBO.Instance;
            var accounts = bo.Accounts;
            for (int i = 0, c = accounts.Count; i < c; ++i)
            {
                if (accounts[i] == bo.SelectedAccount)
                {
                    sel = i;
                    break;
                }
            }
            selectedIndex = sel;
            lbAccounts.SelectedIndex = sel;
        }

        private void OnSelectedAccountIndex(object sender, MaterialListBoxItem selectedItem)
        {
            var bo = AccountManagerBO.Instance;
            if (editing)
            {
                bo.CancelEdit();
                editing = false;
            }
            selectedIndex = lbAccounts.SelectedIndex;
            bo.SelectedAccount = (Account?)selectedItem.Tag;
            LoadActions();
            LoadInfo();
        }

        private void OnBack(object sender, EventArgs e)
        {
            var bo = AccountManagerBO.Instance;
            if (searching)
            {
                tbSearchBox.Text = string.Empty;
                bo.Searching = false;
                searching = false;
                LoadAccounts();
                AdjustSelectedIndex();
            }
            else if (editing)
            {
                editing = false;
                bo.CancelEdit();
                if (selectedIndex >= 0)
                    bo.SelectedAccount = bo.Accounts[selectedIndex];
            }
            else if (ClientSize.Width < 600 && selectedIndex >= 0)
            {
                selectedIndex = -1;
                lbAccounts.SelectedIndex = -1;
                bo.SelectedAccount = null;

            }
            else return;
            LoadActions();
            LoadInfo();
        }

        private void OnSave(object sender, EventArgs e)
        {
            var bo = AccountManagerBO.Instance;
            if ((selectedIndex >= 0 || bo.SelectedAccount != null)
                && ucAccountInfo.CanSaveAccount())
            {
                ucAccountInfo.SaveAccount();
                bo.AcceptEdit();
                editing = false;
                LoadAccounts();
                AdjustSelectedIndex();
                LoadActions();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không hợp lệ!",
                    "Lưu tài khoản", MessageBoxButtons.OK);
            }
        }

        private void OnStartSearch(object sender, EventArgs e)
        {
            AccountManagerBO.Instance.Searching = true;
            searching = true;
            LoadAccounts();
            AdjustSelectedIndex();
            LoadActions();
        }

        private void OnLookingUp(object sender, EventArgs e)
        {
            var bo = AccountManagerBO.Instance;
            bo.LookupAccount(tbSearchBox.Text);
            LoadAccounts();
            AdjustSelectedIndex();
            LoadActions();
            LoadInfo();
        }

        private void OnAdding(object sender, EventArgs e)
        {
            AccountManagerBO.Instance.CreateAccount();
            editing = true;
            LoadActions();
            LoadInfo();
        }

        private void OnEditing(object sender, EventArgs e)
        {
            var bo = AccountManagerBO.Instance;
            bo.SelectedAccount = bo.Accounts[selectedIndex];
            editing = true;
            LoadActions();
            LoadInfo();
        }

        private void OnDeleting(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tài khoản này không?", "Xóa tài khoản",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                AccountManagerBO.Instance.DeleteAccount();
                selectedIndex = -1;
                editing = false;
                LoadAccounts();
                LoadActions();
                LoadInfo();
            }
        }

        private void OnStartPermissionGroupManager(object sender, EventArgs e)
            => new PermissionGroupManagerUI()
            {
                StartPosition = 0
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
            if (pnAccountInfo.VerticalScroll.Visible)
                scrollSize.Width = SystemInformation.VerticalScrollBarWidth;
            if (pnAccountInfo.HorizontalScroll.Visible)
                scrollSize.Height = SystemInformation.HorizontalScrollBarHeight;
            int width = s.Width;
            if (width >= 600)
            {
                s.Width = (int)(width * 0.4);
                lbAccounts.ClientSize = s;
                pnAccountInfo.Location = new(s.Width, 0);
                s.Width = width - s.Width;
                lbAccounts.Visible = true;
            }
            else
            {
                lbAccounts.ClientSize = s;
                pnAccountInfo.Location = new(0, 0);
                lbAccounts.Visible = selectedIndex < 0;
            }
            pnAccountInfo.ClientSize = s;
            s -= scrollSize;
            ucAccountInfo.ClientSize = new(s.Width, ucAccountInfo.ClientSize.Height);
            pnAccountInfo.AutoScrollMinSize = s;
        }
    }
}
