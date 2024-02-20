namespace HotelManagement.GUI
{
    partial class AccountManagerUI
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
            lbAccounts = new ListBox();
            pnAccountInfo = new Panel();
            ucAccountInfo = new AccountInfoUI();
            lbAccountInfoTitle = new Label();
            toolStrip1 = new ToolStrip();
            btnBack = new ToolStripButton();
            txtTitle = new ToolStripLabel();
            tbSearchBox = new ToolStripTextBox();
            btnSave = new ToolStripButton();
            btnSearch = new ToolStripButton();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnDelete = new ToolStripButton();
            btnSearch = new ToolStripButton();
            panel1 = new Panel();
            btnGroups = new ToolStripButton();
            pnAccountInfo.SuspendLayout();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbAccounts
            // 
            lbAccounts.BackColor = Color.WhiteSmoke;
            lbAccounts.Dock = DockStyle.Left;
            lbAccounts.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbAccounts.Location = new Point(0, 56);
            lbAccounts.Name = "lbAccounts";
            lbAccounts.SelectedIndex = -1;
            lbAccounts.SelectedItem = null;
            lbAccounts.Size = new Size(240, 544);
            lbAccounts.TabIndex = 0;
            lbAccounts.SelectedIndexChanged += OnSelectedAccountIndex;
            // 
            // pnAccountInfo
            // 
            pnAccountInfo.AutoScroll = true;
            pnAccountInfo.BackColor = Color.FromArgb(255, 255, 255);
            pnAccountInfo.Controls.Add(ucAccountInfo);
            pnAccountInfo.Controls.Add(lbAccountInfoTitle);
            pnAccountInfo.Dock = DockStyle.Right;
            pnAccountInfo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pnAccountInfo.Location = new Point(240, 56);
            pnAccountInfo.Margin = new Padding(0);
            pnAccountInfo.Name = "pnAccountInfo";
            pnAccountInfo.Size = new Size(360, 544);
            pnAccountInfo.TabIndex = 1;
            // 
            // ucAccountInfo
            // 
            ucAccountInfo.BackColor = Color.White;
            ucAccountInfo.Dock = DockStyle.Top;
            ucAccountInfo.Editing = false;
            ucAccountInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ucAccountInfo.ForeColor = Color.Black;
            ucAccountInfo.Location = new Point(0, 84);
            ucAccountInfo.MinimumSize = new Size(360, 240);
            ucAccountInfo.Name = "ucAccountInfo";
            ucAccountInfo.Size = new Size(360, 240);
            ucAccountInfo.TabIndex = 0;
            // 
            // lbAccountInfoTitle
            // 
            lbAccountInfoTitle.Dock = DockStyle.Top;
            lbAccountInfoTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbAccountInfoTitle.Location = new Point(0, 0);
            lbAccountInfoTitle.Name = "lbAccountInfoTitle";
            lbAccountInfoTitle.Size = new Size(360, 84);
            lbAccountInfoTitle.TabIndex = 2;
            lbAccountInfoTitle.Text = "Thông tin tài khoản";
            lbAccountInfoTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.White;
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnBack, txtTitle, tbSearchBox, btnGroups, btnDelete, btnEdit, btnAdd, btnSave, btnSearch });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0);
            toolStrip1.Size = new Size(600, 56);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
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
            txtTitle.Text = "Tài khoản";
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
            btnSearch.Size = new Size(246, 44);
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
            panel1.Controls.Add(toolStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 56);
            panel1.TabIndex = 3;
            // 
            // btnGroups
            //
            btnGroups.Alignment = ToolStripItemAlignment.Right;
            btnGroups.AutoSize = false;
            btnGroups.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnGroups.Image = (Image)resources.GetObject("btnGroups.Image");
            btnGroups.ImageTransparentColor = Color.Magenta;
            btnGroups.Margin = new Padding(0);
            btnGroups.Name = "btnGroups";
            btnGroups.Size = new Size(56, 56);
            btnGroups.Text = "Nhóm quyền";
            btnGroups.Click += OnStartPermissionGroupManager;
            // 
            // AccountManagerUI
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(600, 600);
            Controls.Add(pnAccountInfo);
            Controls.Add(lbAccounts);
            Controls.Add(panel1);
            Name = "AccountManagerUI";
            Text = "Tài khoản";
            pnAccountInfo.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbAccounts;
        private AccountInfoUI ucAccountInfo;
        private Label lbAccountInfoTitle;
        private Panel pnAccountInfo;
        private ToolStrip toolStrip1;
        private ToolStripButton btnBack;
        private Panel panel1;
        private ToolStripLabel txtTitle;
        private ToolStripTextBox tbSearchBox;
        private ToolStripButton btnSearch;
        private ToolStripButton btnSave;
        private ToolStripButton btnAdd;
        private ToolStripButton btnEdit;
        private ToolStripButton btnDelete;
        private ToolStripButton btnGroups;
    }
}