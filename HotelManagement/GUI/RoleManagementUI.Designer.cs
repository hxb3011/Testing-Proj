namespace HotelManagement.GUI
{
    partial class RoleManagementUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManagerUI));
            lbRoles = new ListBox();
            pnRoleInfo = new Panel();
            ucRoleInfo = new RoleInfoUI();
            lbRoleInfoTitle = new Label();
            tsAppBar = new ToolStrip();
            btnBack = new ToolStripButton();
            txtTitle = new ToolStripLabel();
            tbSearchBox = new ToolStripTextBox();
            btnDelete = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnAdd = new ToolStripButton();
            btnSave = new ToolStripButton();
            btnSearch = new ToolStripButton();
            pnAppBar = new Panel();
            pnRoleInfo.SuspendLayout();
            tsAppBar.SuspendLayout();
            pnAppBar.SuspendLayout();
            SuspendLayout();
            // 
            // lbAccounts
            // 
            lbRoles.BackColor = Color.WhiteSmoke;
            lbRoles.Dock = DockStyle.Left;
            lbRoles.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbRoles.Location = new Point(0, 56);
            lbRoles.Name = "lbAccounts";
            lbRoles.SelectedIndex = -1;
            lbRoles.SelectedItem = null;
            lbRoles.Size = new Size(240, 544);
            lbRoles.TabIndex = 0;
            lbRoles.SelectedIndexChanged += OnSelectedRoleIndex;
            // 
            // pnAccountInfo
            // 
            pnRoleInfo.AutoScroll = true;
            pnRoleInfo.BackColor = Color.FromArgb(255, 255, 255);
            pnRoleInfo.Controls.Add(ucRoleInfo);
            pnRoleInfo.Controls.Add(lbRoleInfoTitle);
            pnRoleInfo.Dock = DockStyle.Right;
            pnRoleInfo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pnRoleInfo.Location = new Point(240, 56);
            pnRoleInfo.Margin = new Padding(0);
            pnRoleInfo.Name = "pnAccountInfo";
            pnRoleInfo.Size = new Size(360, 544);
            pnRoleInfo.TabIndex = 1;
            // 
            // ucAccountInfo
            // 
            ucRoleInfo.BackColor = Color.White;
            ucRoleInfo.Dock = DockStyle.Top;
            ucRoleInfo.Editing = false;
            ucRoleInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ucRoleInfo.ForeColor = Color.Black;
            ucRoleInfo.Location = new Point(0, 84);
            ucRoleInfo.MinimumSize = new Size(360, 240);
            ucRoleInfo.Name = "ucAccountInfo";
            ucRoleInfo.Size = new Size(360, 240);
            ucRoleInfo.TabIndex = 0;
            // 
            // lbAccountInfoTitle
            // 
            lbRoleInfoTitle.Dock = DockStyle.Top;
            lbRoleInfoTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbRoleInfoTitle.Location = new Point(0, 0);
            lbRoleInfoTitle.Name = "lbAccountInfoTitle";
            lbRoleInfoTitle.Size = new Size(360, 84);
            lbRoleInfoTitle.TabIndex = 2;
            lbRoleInfoTitle.Text = "Thông tin chức vụ";
            lbRoleInfoTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            tsAppBar.BackColor = Color.White;
            tsAppBar.Dock = DockStyle.Fill;
            tsAppBar.GripStyle = ToolStripGripStyle.Hidden;
            tsAppBar.ImageScalingSize = new Size(24, 24);
            tsAppBar.Items.AddRange(new ToolStripItem[] { btnBack, txtTitle, tbSearchBox, btnDelete, btnEdit, btnAdd, btnSave, btnSearch });
            tsAppBar.Location = new Point(0, 0);
            tsAppBar.Name = "toolStrip1";
            tsAppBar.Padding = new Padding(0);
            tsAppBar.Size = new Size(600, 56);
            tsAppBar.TabIndex = 2;
            tsAppBar.Text = "toolStrip1";
            // 
            // btnBack
            // 
            btnBack.AutoSize = false;
            btnBack.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.ImageTransparentColor = Color.Magenta;
            btnBack.Margin = new Padding(0);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(56, 56);
            btnBack.Text = "Trở về";
            btnBack.Click += OnBack;
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = false;
            txtTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTitle.Margin = new Padding(16, 0, 0, 0);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(232, 50);
            txtTitle.Text = "Chức vụ";
            txtTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbSearchBox
            // 
            tbSearchBox.AutoSize = false;
            tbSearchBox.BorderStyle = BorderStyle.FixedSingle;
            tbSearchBox.Margin = new Padding(0);
            tbSearchBox.Name = "tbSearchBox";
            tbSearchBox.Size = new Size(248, 39);
            tbSearchBox.TextChanged += OnLookingUp;
            // 
            // btnSave
            // 
            btnSave.Alignment = ToolStripItemAlignment.Right;
            btnSave.AutoSize = false;
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(56, 56);
            btnSave.Text = "Hoàn tất";
            btnSave.Click += OnSave;
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(56, 56);
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += OnStartSearch;
            // 
            // btnAdd
            // 
            btnAdd.Alignment = ToolStripItemAlignment.Right;
            btnAdd.AutoSize = false;
            btnAdd.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Margin = new Padding(0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(56, 56);
            btnAdd.Text = "Thêm";
            btnAdd.Click += OnAdding;
            // 
            // btnEdit
            // 
            btnEdit.Alignment = ToolStripItemAlignment.Right;
            btnEdit.AutoSize = false;
            btnEdit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageTransparentColor = Color.Magenta;
            btnEdit.Margin = new Padding(0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(56, 56);
            btnEdit.Text = "Sửa";
            btnEdit.Click += OnEditing;
            // 
            // btnDelete
            // 
            btnDelete.Alignment = ToolStripItemAlignment.Right;
            btnDelete.AutoSize = false;
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(56, 56);
            btnDelete.Text = "Xóa";
            btnDelete.Click += OnDeleting;
            // 
            // btnSearch
            // 
            btnSearch.Alignment = ToolStripItemAlignment.Right;
            btnSearch.AutoSize = false;
            btnSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageTransparentColor = Color.Magenta;
            btnSearch.Margin = new Padding(0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(56, 56);
            btnSearch.Text = "Tìm kiếm";
            btnSearch.Click += OnStartSearch;
            // 
            // panel1
            // 
            pnAppBar.Controls.Add(tsAppBar);
            pnAppBar.Dock = DockStyle.Top;
            pnAppBar.Location = new Point(0, 0);
            pnAppBar.Name = "panel1";
            pnAppBar.Size = new Size(600, 56);
            pnAppBar.TabIndex = 3;
            // 
            // AccountManagerUI
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(600, 600);
            Controls.Add(pnRoleInfo);
            Controls.Add(lbRoles);
            Controls.Add(pnAppBar);
            Name = "RoleManagementUI";
            Text = "Chức vụ";
            pnRoleInfo.ResumeLayout(false);
            tsAppBar.ResumeLayout(false);
            tsAppBar.PerformLayout();
            pnAppBar.ResumeLayout(false);
            pnAppBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbRoles;
        private RoleInfoUI ucRoleInfo;
        private Label lbRoleInfoTitle;
        private Panel pnRoleInfo;
        private ToolStrip tsAppBar;
        private ToolStripButton btnBack;
        private Panel pnAppBar;
        private ToolStripLabel txtTitle;
        private ToolStripTextBox tbSearchBox;
        private ToolStripButton btnSearch;
        private ToolStripButton btnDelete;
        private ToolStripButton btnEdit;
        private ToolStripButton btnAdd;
        private ToolStripButton btnSave;
    }
}