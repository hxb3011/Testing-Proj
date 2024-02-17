namespace HotelManagement.GUI
{
    partial class ConvinienceInfoUI
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
            groupBox2 = new GroupBox();
            txbName = new TextBox();
            groupBox1 = new GroupBox();
            txbID = new TextBox();
            errName = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(469, 72);
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
            tableLayoutPanel2.Size = new Size(469, 72);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.None;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(166, 26);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(136, 19);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Thông tin phòng";
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 255);
            panel3.Name = "panel3";
            panel3.Size = new Size(469, 51);
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
            tableLayoutPanel1.Size = new Size(469, 51);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.None;
            btnReset.BackColor = SystemColors.HotTrack;
            btnReset.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.ForeColor = SystemColors.ButtonHighlight;
            btnReset.Location = new Point(272, 8);
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
            btnSave.Location = new Point(37, 8);
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
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 72);
            panel2.Margin = new Padding(20, 0, 20, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(469, 183);
            panel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txbName);
            groupBox2.Controls.Add(errName);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(469, 72);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tên tiện nghi";
            // 
            // txbName
            // 
            txbName.Dock = DockStyle.Fill;
            txbName.Location = new Point(3, 19);
            txbName.Name = "txbName";
            txbName.Size = new Size(463, 23);
            txbName.TabIndex = 1;
            txbName.TextChanged += txbName_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbID);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 58);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mã tiện nghi";
            // 
            // txbID
            // 
            txbID.Dock = DockStyle.Fill;
            txbID.Location = new Point(3, 19);
            txbID.Name = "txbID";
            txbID.Size = new Size(463, 23);
            txbID.TabIndex = 0;
            // 
            // errName
            // 
            errName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            errName.ForeColor = Color.Red;
            errName.Location = new Point(6, 45);
            errName.Name = "errName";
            errName.Size = new Size(457, 22);
            errName.TabIndex = 3;
            // 
            // ConvinienceInfoUI
            // 
            ClientSize = new Size(469, 306);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "ConvinienceInfoUI";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
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
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox txbID;
        private TextBox txbName;
        private Label errName;
    }
}