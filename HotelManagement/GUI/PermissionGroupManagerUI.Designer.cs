namespace HotelManagement.GUI
{
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    partial class PermissionGroupManagerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermissionGroupManagerUI));
            lbGroups = new ListBox();
            pnGroupInfo = new Panel();
            ucGranting = new GrantingPermissionsUI();
            ucGroupInfo = new PermissonGroupInfoUI();
            lbGroupInfoTitle = new Label();
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
            pnGroupInfo.SuspendLayout();
            tsAppBar.SuspendLayout();
            pnAppBar.SuspendLayout();
            SuspendLayout();
            // 
            // lbGroups
            // 
            lbGroups.BackColor = Color.WhiteSmoke;
            lbGroups.Dock = DockStyle.Left;
            lbGroups.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbGroups.Location = new Point(0, 56);
            lbGroups.Name = "lbGroups";
            lbGroups.Size = new Size(240, 544);
            lbGroups.TabIndex = 0;
            lbGroups.SelectedIndexChanged += OnSelectedGroupIndex;
            // 
            // pnGroupInfo
            // 
            pnGroupInfo.AutoScroll = true;
            pnGroupInfo.BackColor = Color.FromArgb(255, 255, 255);
            pnGroupInfo.Controls.Add(ucGranting);
            pnGroupInfo.Controls.Add(ucGroupInfo);
            pnGroupInfo.Controls.Add(lbGroupInfoTitle);
            pnGroupInfo.Dock = DockStyle.Right;
            pnGroupInfo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pnGroupInfo.Location = new Point(240, 56);
            pnGroupInfo.Margin = new Padding(0);
            pnGroupInfo.Name = "pnGroupInfo";
            pnGroupInfo.Size = new Size(360, 544);
            pnGroupInfo.TabIndex = 1;
            // 
            // ucGranting
            // 
            ucGranting.BackColor = Color.White;
            ucGranting.Dock = DockStyle.Top;
            ucGranting.Editing = false;
            ucGranting.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ucGranting.ForeColor = Color.Black;
            ucGranting.Location = new Point(0, 220);
            ucGranting.Margin = new Padding(4);
            ucGranting.MinimumSize = new Size(360, 0);
            ucGranting.Name = "ucGranting";
            ucGranting.Size = new Size(360, 1280);
            ucGranting.TabIndex = 1;
            // 
            // ucGroupInfo
            // 
            ucGroupInfo.BackColor = Color.White;
            ucGroupInfo.Dock = DockStyle.Top;
            ucGroupInfo.Editing = false;
            ucGroupInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ucGroupInfo.ForeColor = Color.Black;
            ucGroupInfo.Location = new Point(0, 84);
            ucGroupInfo.MinimumSize = new Size(360, 136);
            ucGroupInfo.Name = "ucGroupInfo";
            ucGroupInfo.Size = new Size(360, 136);
            ucGroupInfo.TabIndex = 0;
            // 
            // lbGroupInfoTitle
            // 
            lbGroupInfoTitle.Dock = DockStyle.Top;
            lbGroupInfoTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbGroupInfoTitle.Location = new Point(0, 0);
            lbGroupInfoTitle.Name = "lbGroupInfoTitle";
            lbGroupInfoTitle.Size = new Size(334, 84);
            lbGroupInfoTitle.TabIndex = 2;
            lbGroupInfoTitle.Text = "Thông tin nhóm quyền";
            lbGroupInfoTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tsAppBar
            // 
            tsAppBar.BackColor = Color.White;
            tsAppBar.Dock = DockStyle.Fill;
            tsAppBar.GripStyle = ToolStripGripStyle.Hidden;
            tsAppBar.ImageScalingSize = new Size(24, 24);
            tsAppBar.Items.AddRange(new ToolStripItem[] { btnBack, txtTitle, tbSearchBox, btnDelete, btnEdit, btnAdd, btnSave, btnSearch });
            tsAppBar.Location = new Point(0, 0);
            tsAppBar.Name = "tsAppBar";
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
            txtTitle.Text = "Nhóm quyền";
            txtTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbSearchBox
            // 
            tbSearchBox.AutoSize = false;
            tbSearchBox.BorderStyle = BorderStyle.FixedSingle;
            tbSearchBox.Margin = new Padding(0);
            tbSearchBox.Name = "tbSearchBox";
            tbSearchBox.Size = new Size(248, 31);
            tbSearchBox.TextChanged += OnLookingUp;
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
            // pnAppBar
            // 
            pnAppBar.Controls.Add(tsAppBar);
            pnAppBar.Dock = DockStyle.Top;
            pnAppBar.Location = new Point(0, 0);
            pnAppBar.Name = "pnAppBar";
            pnAppBar.Size = new Size(600, 56);
            pnAppBar.TabIndex = 3;
            // 
            // PermissionGroupManagerUI
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(600, 600);
            Controls.Add(pnGroupInfo);
            Controls.Add(lbGroups);
            Controls.Add(pnAppBar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            Name = "PermissionGroupManagerUI";
            Text = "Nhóm quyền";
            pnGroupInfo.ResumeLayout(false);
            tsAppBar.ResumeLayout(false);
            tsAppBar.PerformLayout();
            pnAppBar.ResumeLayout(false);
            pnAppBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbGroups;
        private PermissonGroupInfoUI ucGroupInfo;
        private GrantingPermissionsUI ucGranting;
        private Label lbGroupInfoTitle;
        private Panel pnGroupInfo;
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