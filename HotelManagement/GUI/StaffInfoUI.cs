namespace HotelManagement.GUI
{
    using HotelManagement.Business;
    using HotelManagement.Data;
    using HotelManagement.Data.Transfer;

    using Microsoft.EntityFrameworkCore.Metadata.Internal;

    using System;
    using System.Drawing;
    using System.Globalization;
    using System.Windows.Forms;

    public partial class StaffInfoUI : UserControl
    {
        public StaffInfoUI()
        {
            InitializeComponent();
            Editing = false;
            cbRole.DisplayMember = nameof(Role.Name);
            cbGroup.DisplayMember = nameof(PermissionGroup.Name);
            cbAccount.DisplayMember = nameof(Account.UserName);
        }

        private bool editing;
        public bool Editing
        {
            get => editing;
            set
            {
                editing = value;
                tbID.ReadOnly = true;
                if (value)
                {
                    var bo = StaffManagerBO.Instance;
                    tbFullName.ReadOnly = false;
                    lbFullNameError.Visible = !bo.IsValidName(tbFullName.Text);
                    cbGender.Enabled = true;
                    dpBirthday.Enabled = true;
                    tbAddress.ReadOnly = false;
                    lbAddressError.Visible = !bo.IsValidAddress(tbAddress.Text);
                    tbCitizenId.ReadOnly = false;
                    lbCitizenIdError.Visible = !bo.IsValidCitizenId(tbCitizenId.Text);
                    tbPhone.ReadOnly = false;
                    lbPhoneError.Visible = !bo.IsValidPhone(tbPhone.Text);
                    cbRole.Enabled = true;
                    tbSalary.ReadOnly = false;
                    lbSalaryError.Visible = !double.TryParse(tbSalary.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out double salary) || salary < 0;
                    cbAccount.Enabled = true;
                    cbGroup.Enabled = true;
                    cbStatus.Enabled = true;
                }
                else
                {
                    tbFullName.ReadOnly = true;
                    lbFullNameError.Visible = false;
                    cbGender.Enabled = false;
                    dpBirthday.Enabled = false;
                    tbAddress.ReadOnly = true;
                    lbAddressError.Visible = false;
                    tbCitizenId.ReadOnly = true;
                    lbCitizenIdError.Visible = false;
                    tbPhone.ReadOnly = true;
                    lbPhoneError.Visible = false;
                    cbRole.Enabled = false;
                    tbSalary.ReadOnly = true;
                    lbSalaryError.Visible = false;
                    cbAccount.Enabled = false;
                    cbGroup.Enabled = false;
                    cbStatus.Enabled = false;
                }
            }
        }

        public void LoadStaff()
        {
            var bo = StaffManagerBO.Instance;
            var sa = bo.SelectedStaff;
            if (sa == null)
            {
                tbID.Text = string.Empty;
                tbFullName.Text = string.Empty;
                cbGender.Items.Clear();
                dpBirthday.Value = DateTime.Now;
                tbAddress.Text = string.Empty;
                tbCitizenId.Text = string.Empty;
                tbPhone.Text = string.Empty;
                tbSalary.Text = "0";
                cbStatus.Checked = true;
            }
            else
            {
                tbID.Text = sa.IdString();
                tbFullName.Text = sa.FullName;
                cbGender.Items.Clear();
                cbGender.Items.Add(Staff.GenderFemaleString);
                cbGender.Items.Add(Staff.GenderMaleString);
                cbGender.SelectedIndex = sa.Gender == Staff.GenderMale ? 1 : 0;
                dpBirthday.Value = sa.Birthday.ToDateTime(TimeOnly.MinValue);
                tbAddress.Text = sa.Address;
                tbCitizenId.Text = sa.CitizenId;
                tbPhone.Text = sa.Phone;
                tbSalary.Text = sa.Salary.ToString(CultureInfo.CurrentCulture);
                cbStatus.Checked = sa.Resign;
            }
            LoadRole();
            LoadAccount();
            LoadGroup();
        }

        private void LoadGroup()
        {
            var bo = StaffManagerBO.Instance;
            var sa = bo.SelectedStaff;
            if (sa == null)
            {
                cbGroup.Items.Clear();
                return;
            }
            cbGroup.SelectedIndex = -1;

            var gd = bo.Groups;
            var c = gd.Count;
            if (cbGroup.Items.Count == 0)
            {
                for (int i = 0; i < c; ++i)
                    cbGroup.Items.Add(gd[i]);
            }

            var gc = sa.Group;
            if (gc == null) return;
            for (int i = 0; i < c; ++i)
            {
                if (gd[i].Id == gc.Id)
                {
                    cbGroup.SelectedIndex = i;
                    break;
                }
            }
        }

        private void LoadAccount()
        {
            var bo = StaffManagerBO.Instance;
            var sa = bo.SelectedStaff;
            cbAccount.Items.Clear();
            if (sa == null) return;
            var ad = bo.Accounts;
            var ac = sa.Account;
            var c = ad.Count;
            for (int i = 0; i < c; ++i)
            {
                var a = ad[i];
                cbAccount.Items.Add(a);
                if (ac != null && (a == ac || a.Uid == ac.Uid))
                {
                    cbAccount.SelectedIndex = i;
                    ac = null;
                }
            }
            cbAccount.Items.Add(new Account() { UserName = "(Không xác định)" });
            if (sa.Account == null) cbAccount.SelectedIndex = c;
        }

        private void LoadRole()
        {
            var bo = StaffManagerBO.Instance;
            var sa = bo.SelectedStaff;
            if (sa == null)
            {
                cbRole.Items.Clear();
                return;
            }
            cbRole.SelectedIndex = -1;

            var rd = bo.Roles;
            var c = rd.Count;
            if (cbRole.Items.Count == 0)
            {
                for (int i = 0; i < c; ++i)
                    cbRole.Items.Add(rd[i]);
            }

            var rc = sa.Role;
            if (rc == null) return;
            for (int i = 0; i < c; ++i)
            {
                if (rd[i].Id == rc.Id)
                {
                    cbRole.SelectedIndex = i;
                    break;
                }
            }
        }

        public bool CanSaveStaff()
            => Editing && !lbFullNameError.Visible
                && !lbAddressError.Visible
                && !lbCitizenIdError.Visible
                && !lbPhoneError.Visible
                && !lbSalaryError.Visible;

        public void SaveStaff()
        {
            var sa = StaffManagerBO.Instance.SelectedStaff;
            if (sa == null) return;
            sa.FullName = tbFullName.Text;
            sa.Gender = cbGender.SelectedIndex == 0 ? Staff.GenderFemale : Staff.GenderMale;
            sa.Birthday = DateOnly.FromDateTime(dpBirthday.Value);
            sa.Address = tbAddress.Text;
            sa.CitizenId = tbCitizenId.Text;
            sa.Phone = tbPhone.Text;
            sa.Salary = double.Parse(tbSalary.Text, NumberStyles.Any, CultureInfo.CurrentCulture);
            sa.Resign = cbStatus.Checked;
            var items = cbRole.Items;
            var index = cbRole.SelectedIndex;
            sa.Role = (uint)index < (uint)items.Count ? (Role)items[index] : null;
            items = cbGroup.Items;
            index = cbGroup.SelectedIndex;
            var group = (uint)index < (uint)items.Count ? (PermissionGroup)items[index] : null;
            items = cbAccount.Items;
            index = cbAccount.SelectedIndex;
            var account = (uint)index < (uint)(items.Count - 1) ? (Account)items[index] : null;
            ((IAccessable)sa).Edit().Assign(account, group);
            Editing = false;
        }

        private void OnFullNameChanged(object sender, EventArgs e)
            => lbFullNameError.Visible = !StaffManagerBO.Instance.IsValidName(tbFullName.Text);
        private void OnAddressChanged(object sender, EventArgs e)
            => lbAddressError.Visible = !StaffManagerBO.Instance.IsValidAddress(tbAddress.Text);
        private void OnCitizenIdChanged(object sender, EventArgs e)
            => lbCitizenIdError.Visible = !StaffManagerBO.Instance.IsValidCitizenId(tbCitizenId.Text);
        private void OnPhoneNumberChanged(object sender, EventArgs e)
            => lbPhoneError.Visible = !StaffManagerBO.Instance.IsValidPhone(tbPhone.Text);
        private void OnSalaryChanged(object sender, EventArgs e)
            => lbSalaryError.Visible = !double.TryParse(tbSalary.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out double salary) || salary < 0;

        public event EventHandler PermissionsInfoChanged;

        private void OnPermissionsInfoChanged(object sender, EventArgs e)
        {
            var bo = GrantingPermissionsBO.Instance;
            var items = cbGroup.Items;
            var index = cbGroup.SelectedIndex;
            bo.Group = (uint)index < (uint)items.Count ? (PermissionGroup)items[index] : null;
            items = cbAccount.Items;
            index = cbAccount.SelectedIndex;
            bo.Account = (uint)index < (uint)(items.Count - 1) ? (Account)items[index] : null;
            PermissionsInfoChanged?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int width = Size.Width - 360, offset = width / 4, value;
            width -= offset << 1;
            value = 16 + offset;
            lbID.Left = value;
            lbFullName.Left = value;
            lbGender.Left = value;
            lbBirthday.Left = value;
            lbAddress.Left = value;
            lbCitizenId.Left = value;
            lbPhone.Left = value;
            lbRole.Left = value;
            lbSalary.Left = value;
            lbAccount.Left = value;
            lbGroup.Left = value;
            lbStatus.Left = value;

            value = 144 + offset;
            tbID.Left = value;
            tbFullName.Left = value;
            lbFullNameError.Left = value;
            cbGender.Left = value;
            dpBirthday.Left = value;
            tbAddress.Left = value;
            lbAddressError.Left = value;
            tbCitizenId.Left = value;
            lbCitizenIdError.Left = value;
            tbPhone.Left = value;
            lbPhoneError.Left = value;
            cbRole.Left = value;
            tbSalary.Left = value;
            lbSalaryError.Left = value;
            cbAccount.Left = value;
            cbGroup.Left = value;
            cbStatus.Left = value;

            value = 200 + width;
            tbID.Width = value;
            tbFullName.Width = value;
            cbGender.Width = value;
            dpBirthday.Width = value;
            tbAddress.Width = value;
            tbCitizenId.Width = value;
            tbPhone.Width = value;
            cbRole.Width = value;
            tbSalary.Width = value;
            cbAccount.Width = value;
            cbGroup.Width = value;
            cbStatus.Width = value;
        }
    }
}
