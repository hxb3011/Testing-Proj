namespace HotelManagement.GUI
{
    partial class RoomInfoUI
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
            panel4 = new Panel();
            tableLayoutPanelThongTin = new TableLayoutPanel();
            panel5 = new Panel();
            groupBox4 = new GroupBox();
            panel8 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            labelUnitPriceChange = new Label();
            label3 = new Label();
            panel7 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            labelNameTypeChange = new Label();
            label1 = new Label();
            panel6 = new Panel();
            groupBox5 = new GroupBox();
            panel10 = new Panel();
            listViewConvinience = new ListView();
            panel9 = new Panel();
            groupBox3 = new GroupBox();
            cbbRoomTypeID = new ComboBox();
            groupBox2 = new GroupBox();
            cbbStatus = new ComboBox();
            groupBox1 = new GroupBox();
            txbID = new TextBox();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanelThongTin.SuspendLayout();
            panel5.SuspendLayout();
            groupBox4.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox5.SuspendLayout();
            panel10.SuspendLayout();
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
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanelThongTin);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 217);
            panel4.Name = "panel4";
            panel4.Size = new Size(875, 163);
            panel4.TabIndex = 5;
            // 
            // tableLayoutPanelThongTin
            // 
            tableLayoutPanelThongTin.ColumnCount = 2;
            tableLayoutPanelThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelThongTin.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelThongTin.Controls.Add(panel5, 0, 0);
            tableLayoutPanelThongTin.Controls.Add(groupBox5, 1, 0);
            tableLayoutPanelThongTin.Dock = DockStyle.Fill;
            tableLayoutPanelThongTin.Location = new Point(0, 0);
            tableLayoutPanelThongTin.Name = "tableLayoutPanelThongTin";
            tableLayoutPanelThongTin.RowCount = 1;
            tableLayoutPanelThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelThongTin.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelThongTin.Size = new Size(875, 163);
            tableLayoutPanelThongTin.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(groupBox4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(431, 157);
            panel5.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(panel8);
            groupBox4.Controls.Add(panel7);
            groupBox4.Controls.Add(panel6);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(431, 157);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Loại phòng";
            // 
            // panel8
            // 
            panel8.Controls.Add(tableLayoutPanel4);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(3, 101);
            panel8.Name = "panel8";
            panel8.Size = new Size(425, 46);
            panel8.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
            tableLayoutPanel4.Controls.Add(labelUnitPriceChange, 1, 0);
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Top;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(425, 34);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // labelUnitPriceChange
            // 
            labelUnitPriceChange.Anchor = AnchorStyles.Left;
            labelUnitPriceChange.AutoSize = true;
            labelUnitPriceChange.Location = new Point(156, 9);
            labelUnitPriceChange.Name = "labelUnitPriceChange";
            labelUnitPriceChange.Size = new Size(48, 15);
            labelUnitPriceChange.TabIndex = 1;
            labelUnitPriceChange.Text = "Đơn giá";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 0;
            label3.Text = "Đơn giá";
            // 
            // panel7
            // 
            panel7.Controls.Add(tableLayoutPanel3);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(3, 55);
            panel7.Name = "panel7";
            panel7.Size = new Size(425, 46);
            panel7.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64F));
            tableLayoutPanel3.Controls.Add(labelNameTypeChange, 1, 0);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(425, 34);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // labelNameTypeChange
            // 
            labelNameTypeChange.Anchor = AnchorStyles.Left;
            labelNameTypeChange.AutoSize = true;
            labelNameTypeChange.Location = new Point(156, 9);
            labelNameTypeChange.Name = "labelNameTypeChange";
            labelNameTypeChange.Size = new Size(85, 15);
            labelNameTypeChange.TabIndex = 1;
            labelNameTypeChange.Text = "Tên loại phòng";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên loại phòng";
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(3, 19);
            panel6.Name = "panel6";
            panel6.Size = new Size(425, 36);
            panel6.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(panel10);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.FlatStyle = FlatStyle.System;
            groupBox5.Location = new Point(440, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(432, 157);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tiện nghi";
            // 
            // panel10
            // 
            panel10.AutoScroll = true;
            panel10.Controls.Add(listViewConvinience);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(3, 19);
            panel10.Name = "panel10";
            panel10.Size = new Size(426, 135);
            panel10.TabIndex = 0;
            // 
            // listViewConvinience
            // 
            listViewConvinience.Dock = DockStyle.Top;
            listViewConvinience.FullRowSelect = true;
            listViewConvinience.Location = new Point(0, 0);
            listViewConvinience.MultiSelect = false;
            listViewConvinience.Name = "listViewConvinience";
            listViewConvinience.Size = new Size(426, 128);
            listViewConvinience.TabIndex = 0;
            listViewConvinience.UseCompatibleStateImageBehavior = false;
            listViewConvinience.View = View.Details;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 174);
            panel9.Name = "panel9";
            panel9.Size = new Size(875, 43);
            panel9.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbbRoomTypeID);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 116);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(875, 58);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Mã loại phòng";
            // 
            // cbbRoomTypeID
            // 
            cbbRoomTypeID.Dock = DockStyle.Fill;
            cbbRoomTypeID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbRoomTypeID.FormattingEnabled = true;
            cbbRoomTypeID.Location = new Point(3, 19);
            cbbRoomTypeID.Name = "cbbRoomTypeID";
            cbbRoomTypeID.Size = new Size(869, 23);
            cbbRoomTypeID.TabIndex = 0;
            cbbRoomTypeID.SelectedValueChanged += cbbRoomTypeID_SelectedValueChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbbStatus);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(875, 58);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tình trạng";
            // 
            // cbbStatus
            // 
            cbbStatus.Dock = DockStyle.Fill;
            cbbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbStatus.FormattingEnabled = true;
            cbbStatus.Location = new Point(3, 19);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new Size(869, 23);
            cbbStatus.TabIndex = 0;
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
            groupBox1.Text = "Mã phòng";
            // 
            // txbID
            // 
            txbID.Dock = DockStyle.Fill;
            txbID.Location = new Point(3, 19);
            txbID.Name = "txbID";
            txbID.Size = new Size(869, 23);
            txbID.TabIndex = 0;
            // 
            // RoomInfoUI
            // 
            ClientSize = new Size(875, 684);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "RoomInfoUI";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanelThongTin.ResumeLayout(false);
            panel5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel7.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBox5.ResumeLayout(false);
            panel10.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
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
        private ComboBox cbbRoomTypeID;
        private GroupBox groupBox2;
        private ComboBox cbbStatus;
        private GroupBox groupBox1;
        private TextBox txbID;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanelThongTin;
        private Panel panel5;
        private GroupBox groupBox4;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel4;
        private Label labelUnitPriceChange;
        private Label label3;
        private Panel panel7;
        private TableLayoutPanel tableLayoutPanel3;
        private Label labelNameTypeChange;
        private Label label1;
        private Panel panel6;
        private GroupBox groupBox5;
        private Panel panel9;
        private Panel panel10;
        private ListView listViewConvinience;
    }
}