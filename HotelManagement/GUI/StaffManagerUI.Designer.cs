namespace HotelManagement.GUI
{
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    partial class StaffManagerUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffManagerUI));
            lbStaffs = new ListBox();
            pnStaffInfo = new Panel();
            ucStaffInfo = new StaffInfoUI();
            lbStaffInfoTitle = new Label();
            tsAppBar = new ToolStrip();
            btnBack = new ToolStripButton();
            txtTitle = new ToolStripLabel();
            tbSearchBox = new ToolStripTextBox();
            btnRoleManager = new ToolStripButton();
            btnImex = new ToolStripButton();
            btnDelete = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnAdd = new ToolStripButton();
            btnSave = new ToolStripButton();
            btnSearch = new ToolStripButton();
            pnAppBar = new Panel();
            pnStaffInfo.SuspendLayout();
            tsAppBar.SuspendLayout();
            pnAppBar.SuspendLayout();
            SuspendLayout();
            // 
            // lbStaffs
            // 
            lbStaffs.BackColor = Color.WhiteSmoke;
            lbStaffs.Dock = DockStyle.Left;
            lbStaffs.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lbStaffs.ItemHeight = 20;
            lbStaffs.Location = new Point(0, 56);
            lbStaffs.Name = "lbStaffs";
            lbStaffs.Size = new Size(240, 544);
            lbStaffs.TabIndex = 0;
            lbStaffs.SelectedIndexChanged += OnSelectedStaffIndex;
            // 
            // pnStaffInfo
            // 
            pnStaffInfo.AutoScroll = true;
            pnStaffInfo.BackColor = Color.FromArgb(255, 255, 255);
            pnStaffInfo.Controls.Add(ucStaffInfo);
            pnStaffInfo.Controls.Add(lbStaffInfoTitle);
            pnStaffInfo.Dock = DockStyle.Right;
            pnStaffInfo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            pnStaffInfo.Location = new Point(240, 56);
            pnStaffInfo.Margin = new Padding(0);
            pnStaffInfo.Name = "pnStaffInfo";
            pnStaffInfo.Size = new Size(360, 544);
            pnStaffInfo.TabIndex = 1;
            // 
            // ucStaffInfo
            // 
            ucStaffInfo.BackColor = Color.White;
            ucStaffInfo.Dock = DockStyle.Top;
            ucStaffInfo.Editing = false;
            ucStaffInfo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ucStaffInfo.ForeColor = Color.Black;
            ucStaffInfo.Location = new Point(0, 84);
            ucStaffInfo.MinimumSize = new Size(360, 660);
            ucStaffInfo.Name = "ucStaffInfo";
            ucStaffInfo.Size = new Size(360, 660);
            ucStaffInfo.TabIndex = 0;
            // 
            // lbStaffInfoTitle
            // 
            lbStaffInfoTitle.Dock = DockStyle.Top;
            lbStaffInfoTitle.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Pixel);
            lbStaffInfoTitle.Location = new Point(0, 0);
            lbStaffInfoTitle.Name = "lbStaffInfoTitle";
            lbStaffInfoTitle.Size = new Size(334, 84);
            lbStaffInfoTitle.TabIndex = 2;
            lbStaffInfoTitle.Text = "Thông tin nhân viên";
            lbStaffInfoTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tsAppBar
            // 
            tsAppBar.BackColor = Color.White;
            tsAppBar.Dock = DockStyle.Fill;
            tsAppBar.GripStyle = ToolStripGripStyle.Hidden;
            tsAppBar.ImageScalingSize = new Size(24, 24);
            tsAppBar.Items.AddRange(new ToolStripItem[] { btnBack, txtTitle, tbSearchBox, btnRoleManager, btnImex, btnDelete, btnEdit, btnAdd, btnSave, btnSearch });
            tsAppBar.Location = new Point(0, 0);
            tsAppBar.Name = "tsAppBar";
            tsAppBar.Padding = new Padding(0);
            tsAppBar.Size = new Size(600, 56);
            tsAppBar.TabIndex = 2;
            tsAppBar.Text = "Nhân viên";
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
            txtTitle.Text = "Nhân viên";
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
            // btnRoleManager
            // 
            btnRoleManager.Alignment = ToolStripItemAlignment.Right;
            btnRoleManager.AutoSize = false;
            btnRoleManager.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnRoleManager.Image = (Image)resources.GetObject("btnRoleManager.Image");
            btnRoleManager.ImageTransparentColor = Color.Magenta;
            btnRoleManager.Margin = new Padding(0);
            btnRoleManager.Name = "btnRoleManager";
            btnRoleManager.Size = new Size(56, 56);
            btnRoleManager.Text = "Chức vụ";
            btnRoleManager.Click += OnStartRoleManager;
            // 
            // btnImex
            // 
            btnImex.Alignment = ToolStripItemAlignment.Right;
            btnImex.AutoSize = false;
            btnImex.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnImex.Image = (Image)resources.GetObject("btnImex.Image");
            btnImex.ImageTransparentColor = Color.Magenta;
            btnImex.Margin = new Padding(0);
            btnImex.Name = "btnImex";
            btnImex.Size = new Size(56, 56);
            btnImex.Text = "Nhập/Xuất";
            btnImex.Click += OnStartImex;
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
            pnAppBar.TabIndex = 2;
            // 
            // StaffManagerUI
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(600, 600);
            Controls.Add(pnStaffInfo);
            Controls.Add(lbStaffs);
            Controls.Add(pnAppBar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            Name = "StaffManagerUI";
            Text = "Nhân viên";
            pnStaffInfo.ResumeLayout(false);
            tsAppBar.ResumeLayout(false);
            tsAppBar.PerformLayout();
            pnAppBar.ResumeLayout(false);
            pnAppBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbStaffs;
        private StaffInfoUI ucStaffInfo;
        private Label lbStaffInfoTitle;
        private Panel pnStaffInfo;
        private ToolStrip tsAppBar;
        private ToolStripButton btnBack;
        private Panel pnAppBar;
        private ToolStripLabel txtTitle;
        private ToolStripTextBox tbSearchBox;
        private ToolStripButton btnSearch;
        private ToolStripButton btnSave;
        private ToolStripButton btnAdd;
        private ToolStripButton btnEdit;
        private ToolStripButton btnDelete;
        private ToolStripButton btnImex;
        private ToolStripButton btnRoleManager;
    }
}