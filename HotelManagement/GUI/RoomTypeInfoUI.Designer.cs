namespace HotelManagement.GUI
{
    partial class RoomTypeInfoUI
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
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelTitle = new Label();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnReset = new Button();
            btnSave = new Button();
            panel2 = new Panel();
            panel7 = new Panel();
            cbbQuantity = new ComboBox();
            label1 = new Label();
            btnActive = new Button();
            panel4 = new Panel();
            tableLayoutPanelThongTin = new TableLayoutPanel();
            panel5 = new Panel();
            groupBoxConvinience = new GroupBox();
            panel6 = new Panel();
            dtgvConvinience = new DataGridView();
            groupBoxConvinienceRoomType = new GroupBox();
            panel10 = new Panel();
            dtgvConvinienceRoomType = new DataGridView();
            panel9 = new Panel();
            groupBox3 = new GroupBox();
            errPrice = new Label();
            txbPrice = new TextBox();
            groupBox2 = new GroupBox();
            errName = new Label();
            txbName = new TextBox();
            groupBox1 = new GroupBox();
            txbID = new TextBox();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanelThongTin.SuspendLayout();
            panel5.SuspendLayout();
            groupBoxConvinience.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvConvinience).BeginInit();
            groupBoxConvinienceRoomType.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvConvinienceRoomType).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 72);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(875, 72);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(369, 26);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(136, 19);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Thông tin phòng";
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 633);
            panel3.Name = "panel3";
            panel3.Size = new Size(875, 51);
            panel3.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnReset, 1, 0);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(875, 51);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.None;
            btnReset.BackColor = SystemColors.HotTrack;
            btnReset.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.ForeColor = SystemColors.ButtonHighlight;
            btnReset.Location = new Point(576, 8);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(159, 34);
            btnReset.TabIndex = 2;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(139, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(159, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu thông tin";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 72);
            panel2.Margin = new Padding(20, 0, 20, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(875, 561);
            panel2.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Controls.Add(cbbQuantity);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(btnActive);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 460);
            panel7.Name = "panel7";
            panel7.Size = new Size(875, 98);
            panel7.TabIndex = 6;
            // 
            // cbbQuantity
            // 
            cbbQuantity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbQuantity.FormattingEnabled = true;
            cbbQuantity.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cbbQuantity.Location = new Point(104, 13);
            cbbQuantity.Name = "cbbQuantity";
            cbbQuantity.Size = new Size(151, 23);
            cbbQuantity.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 11;
            label1.Text = "Số lượng";
            // 
            // btnActive
            // 
            btnActive.Anchor = AnchorStyles.Top;
            btnActive.Location = new Point(464, 16);
            btnActive.Name = "btnActive";
            btnActive.Size = new Size(94, 29);
            btnActive.TabIndex = 9;
            btnActive.Text = "Active";
            btnActive.UseVisualStyleBackColor = true;
            btnActive.Click += btnActive_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanelThongTin);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 250);
            panel4.Name = "panel4";
            panel4.Size = new Size(875, 210);
            panel4.TabIndex = 5;
            // 
            // tableLayoutPanelThongTin
            // 
            tableLayoutPanelThongTin.ColumnCount = 2;
            tableLayoutPanelThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelThongTin.Controls.Add(panel5, 0, 0);
            tableLayoutPanelThongTin.Controls.Add(groupBoxConvinienceRoomType, 1, 0);
            tableLayoutPanelThongTin.Dock = DockStyle.Fill;
            tableLayoutPanelThongTin.Location = new Point(0, 0);
            tableLayoutPanelThongTin.Name = "tableLayoutPanelThongTin";
            tableLayoutPanelThongTin.RowCount = 1;
            tableLayoutPanelThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelThongTin.Size = new Size(875, 210);
            tableLayoutPanelThongTin.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(groupBoxConvinience);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(431, 204);
            panel5.TabIndex = 0;
            // 
            // groupBoxConvinience
            // 
            groupBoxConvinience.Controls.Add(panel6);
            groupBoxConvinience.Dock = DockStyle.Fill;
            groupBoxConvinience.FlatStyle = FlatStyle.System;
            groupBoxConvinience.Location = new Point(0, 0);
            groupBoxConvinience.Name = "groupBoxConvinience";
            groupBoxConvinience.Size = new Size(431, 204);
            groupBoxConvinience.TabIndex = 2;
            groupBoxConvinience.TabStop = false;
            groupBoxConvinience.Text = "Tiện nghi";
            // 
            // panel6
            // 
            panel6.AutoScroll = true;
            panel6.Controls.Add(dtgvConvinience);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 19);
            panel6.Name = "panel6";
            panel6.Size = new Size(425, 182);
            panel6.TabIndex = 0;
            // 
            // dtgvConvinience
            // 
            dtgvConvinience.AllowUserToAddRows = false;
            dtgvConvinience.AllowUserToDeleteRows = false;
            dtgvConvinience.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvConvinience.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvConvinience.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvConvinience.Dock = DockStyle.Fill;
            dtgvConvinience.Location = new Point(0, 0);
            dtgvConvinience.Name = "dtgvConvinience";
            dtgvConvinience.ReadOnly = true;
            dtgvConvinience.RowHeadersWidth = 51;
            dtgvConvinience.RowTemplate.Height = 29;
            dtgvConvinience.Size = new Size(425, 182);
            dtgvConvinience.TabIndex = 2;
            dtgvConvinience.CellClick += dtgvConvinience_CellClick;
            // 
            // groupBoxConvinienceRoomType
            // 
            groupBoxConvinienceRoomType.Controls.Add(panel10);
            groupBoxConvinienceRoomType.Dock = DockStyle.Fill;
            groupBoxConvinienceRoomType.FlatStyle = FlatStyle.System;
            groupBoxConvinienceRoomType.Location = new Point(440, 3);
            groupBoxConvinienceRoomType.Name = "groupBoxConvinienceRoomType";
            groupBoxConvinienceRoomType.Size = new Size(432, 204);
            groupBoxConvinienceRoomType.TabIndex = 1;
            groupBoxConvinienceRoomType.TabStop = false;
            groupBoxConvinienceRoomType.Text = "Tiện nghi loại phòng";
            // 
            // panel10
            // 
            panel10.AutoScroll = true;
            panel10.Controls.Add(dtgvConvinienceRoomType);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(3, 19);
            panel10.Name = "panel10";
            panel10.Size = new Size(426, 182);
            panel10.TabIndex = 0;
            // 
            // dtgvConvinienceRoomType
            // 
            dtgvConvinienceRoomType.AllowUserToAddRows = false;
            dtgvConvinienceRoomType.AllowUserToDeleteRows = false;
            dtgvConvinienceRoomType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvConvinienceRoomType.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvConvinienceRoomType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvConvinienceRoomType.Dock = DockStyle.Fill;
            dtgvConvinienceRoomType.Location = new Point(0, 0);
            dtgvConvinienceRoomType.Name = "dtgvConvinienceRoomType";
            dtgvConvinienceRoomType.ReadOnly = true;
            dtgvConvinienceRoomType.RowHeadersWidth = 51;
            dtgvConvinienceRoomType.RowTemplate.Height = 29;
            dtgvConvinienceRoomType.Size = new Size(426, 182);
            dtgvConvinienceRoomType.TabIndex = 2;
            dtgvConvinienceRoomType.CellClick += dtgvConvinienceRoomType_CellClick;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 207);
            panel9.Name = "panel9";
            panel9.Size = new Size(875, 43);
            panel9.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(errPrice);
            groupBox3.Controls.Add(txbPrice);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 134);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(875, 73);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Giá loại phòng";
            // 
            // errPrice
            // 
            errPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            errPrice.ForeColor = Color.Red;
            errPrice.Location = new Point(3, 45);
            errPrice.Name = "errPrice";
            errPrice.Size = new Size(866, 22);
            errPrice.TabIndex = 3;
            // 
            // txbPrice
            // 
            txbPrice.Dock = DockStyle.Fill;
            txbPrice.Location = new Point(3, 19);
            txbPrice.Name = "txbPrice";
            txbPrice.Size = new Size(869, 23);
            txbPrice.TabIndex = 1;
            txbPrice.TextChanged += txbPrice_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(errName);
            groupBox2.Controls.Add(txbName);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(875, 76);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tên loại phòng";
            // 
            // errName
            // 
            errName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            errName.ForeColor = Color.Red;
            errName.Location = new Point(3, 51);
            errName.Name = "errName";
            errName.Size = new Size(866, 22);
            errName.TabIndex = 2;
            // 
            // txbName
            // 
            txbName.Dock = DockStyle.Fill;
            txbName.Location = new Point(3, 19);
            txbName.Name = "txbName";
            txbName.Size = new Size(869, 23);
            txbName.TabIndex = 1;
            txbName.TextChanged += txbName_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbID);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(875, 58);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mã loại phòng";
            // 
            // txbID
            // 
            txbID.Dock = DockStyle.Fill;
            txbID.Location = new Point(3, 19);
            txbID.Name = "txbID";
            txbID.Size = new Size(869, 23);
            txbID.TabIndex = 0;
            // 
            // RoomTypeInfoUI
            // 
            ClientSize = new Size(875, 684);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "RoomTypeInfoUI";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanelThongTin.ResumeLayout(false);
            panel5.ResumeLayout(false);
            groupBoxConvinience.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvConvinience).EndInit();
            groupBoxConvinienceRoomType.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvConvinienceRoomType).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }





        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelTitle;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSave;
        private Button btnReset;
        private Panel panel3;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox txbID;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanelThongTin;
        private Panel panel5;
        private GroupBox groupBoxConvinienceRoomType;
        private Panel panel9;
        private Panel panel10;
        private TextBox txbPrice;
        private TextBox txbName;
        private GroupBox groupBoxConvinience;
        private Panel panel6;
        private DataGridView dtgvConvinience;
        private DataGridView dtgvConvinienceRoomType;
        private Panel panel7;
        private Label label1;
        private Button btnActive;
        private ComboBox cbbQuantity;
        private Label errPrice;
        private Label errName;
    }
}