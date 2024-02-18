namespace HotelManagement.GUI
{
    partial class CustomerInfoUI
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

        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnReset = new Button();
            btnSave = new Button();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel4 = new Panel();
            txtId = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            errFullName = new Label();
            txtFullname = new TextBox();
            label5 = new Label();
            panel6 = new Panel();
            cbxGender = new ComboBox();
            label7 = new Label();
            panel7 = new Panel();
            errCCCD = new Label();
            txtCCCD = new TextBox();
            label9 = new Label();
            panel8 = new Panel();
            errPhone = new Label();
            txtPhone = new TextBox();
            label11 = new Label();
            panel9 = new Panel();
            dateTimeBirthday = new DateTimePicker();
            label12 = new Label();
            label13 = new Label();
            panel10 = new Panel();
            errAddress = new Label();
            txtAddress = new TextBox();
            label15 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(491, 72);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(491, 72);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(137, 24);
            label1.Name = "label1";
            label1.Size = new Size(217, 24);
            label1.TabIndex = 0;
            label1.Text = "Thông tin khách hàng";
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 658);
            panel3.Name = "panel3";
            panel3.Size = new Size(491, 51);
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
            tableLayoutPanel1.Size = new Size(491, 51);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.None;
            btnReset.BackColor = SystemColors.HotTrack;
            btnReset.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.ForeColor = SystemColors.ButtonHighlight;
            btnReset.Location = new Point(288, 8);
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
            btnSave.Location = new Point(43, 8);
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
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 72);
            panel2.Margin = new Padding(20, 0, 20, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(491, 586);
            panel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Controls.Add(panel9);
            flowLayoutPanel1.Controls.Add(panel10);
            flowLayoutPanel1.Location = new Point(3, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(485, 579);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtId);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(473, 60);
            panel4.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(16, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(440, 27);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 10);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã khách hàng";
            // 
            // panel5
            // 
            panel5.Controls.Add(errFullName);
            panel5.Controls.Add(txtFullname);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(3, 69);
            panel5.Name = "panel5";
            panel5.Size = new Size(473, 80);
            panel5.TabIndex = 1;
            // 
            // errFullName
            // 
            errFullName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            errFullName.ForeColor = Color.Red;
            errFullName.Location = new Point(16, 54);
            errFullName.Name = "errFullName";
            errFullName.Size = new Size(440, 18);
            errFullName.TabIndex = 2;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(16, 28);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(440, 27);
            txtFullname.TabIndex = 1;
            txtFullname.TextChanged += txtFullname_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 10);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 0;
            label5.Text = "Tên khách hàng";
            // 
            // panel6
            // 
            panel6.Controls.Add(cbxGender);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(3, 155);
            panel6.Name = "panel6";
            panel6.Size = new Size(473, 68);
            panel6.TabIndex = 2;
            // 
            // cbxGender
            // 
            cbxGender.FormattingEnabled = true;
            cbxGender.Location = new Point(15, 31);
            cbxGender.Name = "cbxGender";
            cbxGender.Size = new Size(441, 28);
            cbxGender.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 10);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 0;
            label7.Text = "Giới tính";
            // 
            // panel7
            // 
            panel7.Controls.Add(errCCCD);
            panel7.Controls.Add(txtCCCD);
            panel7.Controls.Add(label9);
            panel7.Location = new Point(3, 229);
            panel7.Name = "panel7";
            panel7.Size = new Size(473, 80);
            panel7.TabIndex = 3;
            // 
            // errCCCD
            // 
            errCCCD.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            errCCCD.ForeColor = Color.Red;
            errCCCD.Location = new Point(16, 54);
            errCCCD.Name = "errCCCD";
            errCCCD.Size = new Size(440, 18);
            errCCCD.TabIndex = 2;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(16, 28);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(440, 27);
            txtCCCD.TabIndex = 1;
            txtCCCD.TextChanged += txtCCCD_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 10);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 0;
            label9.Text = "CCCD/CMND";
            // 
            // panel8
            // 
            panel8.Controls.Add(errPhone);
            panel8.Controls.Add(txtPhone);
            panel8.Controls.Add(label11);
            panel8.Location = new Point(3, 315);
            panel8.Name = "panel8";
            panel8.Size = new Size(473, 80);
            panel8.TabIndex = 4;
            // 
            // errPhone
            // 
            errPhone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            errPhone.ForeColor = Color.Red;
            errPhone.Location = new Point(16, 54);
            errPhone.Name = "errPhone";
            errPhone.Size = new Size(440, 18);
            errPhone.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(16, 28);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(440, 27);
            txtPhone.TabIndex = 1;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(16, 10);
            label11.Name = "label11";
            label11.Size = new Size(97, 20);
            label11.TabIndex = 0;
            label11.Text = "Số điện thoại";
            // 
            // panel9
            // 
            panel9.Controls.Add(dateTimeBirthday);
            panel9.Controls.Add(label12);
            panel9.Controls.Add(label13);
            panel9.Location = new Point(3, 401);
            panel9.Name = "panel9";
            panel9.Size = new Size(473, 80);
            panel9.TabIndex = 5;
            // 
            // dateTimeBirthday
            // 
            dateTimeBirthday.CustomFormat = "dd/MM/yyyy";
            dateTimeBirthday.Format = DateTimePickerFormat.Custom;
            dateTimeBirthday.Location = new Point(16, 28);
            dateTimeBirthday.Name = "dateTimeBirthday";
            dateTimeBirthday.Size = new Size(440, 27);
            dateTimeBirthday.TabIndex = 3;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(16, 54);
            label12.Name = "label12";
            label12.Size = new Size(440, 18);
            label12.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 10);
            label13.Name = "label13";
            label13.Size = new Size(74, 20);
            label13.TabIndex = 0;
            label13.Text = "Ngày sinh";
            // 
            // panel10
            // 
            panel10.Controls.Add(errAddress);
            panel10.Controls.Add(txtAddress);
            panel10.Controls.Add(label15);
            panel10.Location = new Point(3, 487);
            panel10.Name = "panel10";
            panel10.Size = new Size(473, 80);
            panel10.TabIndex = 6;
            // 
            // errAddress
            // 
            errAddress.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            errAddress.ForeColor = Color.Red;
            errAddress.Location = new Point(16, 54);
            errAddress.Name = "errAddress";
            errAddress.Size = new Size(440, 18);
            errAddress.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(16, 28);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(440, 27);
            txtAddress.TabIndex = 1;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(16, 10);
            label15.Name = "label15";
            label15.Size = new Size(55, 20);
            label15.TabIndex = 0;
            label15.Text = "Địa chỉ";
            // 
            // CustomerInfoUI
            // 
            ClientSize = new Size(491, 709);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CustomerInfoUI";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSave;
        private Button btnReset;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel4;
        private TextBox txtId;
        private Label label2;
        private Panel panel5;
        private Label errFullName;
        private TextBox txtFullname;
        private Label label5;
        private Panel panel6;
        private Label label7;
        private Panel panel7;
        private Label errCCCD;
        private TextBox txtCCCD;
        private Label label9;
        private Panel panel8;
        private Label errPhone;
        private TextBox txtPhone;
        private Label label11;
        private Panel panel9;
        private Label label12;
        private Label label13;
        private Panel panel10;
        private Label errAddress;
        private TextBox txtAddress;
        private Label label15;
        private DateTimePicker dateTimeBirthday;
        private ComboBox cbxGender;
    }
}