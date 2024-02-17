namespace HotelManagement.GUI
{
    partial class ServiceInfoUI
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
            errName = new Label();
            txtName = new TextBox();
            txt = new Label();
            panel6 = new Panel();
            cbxServiceType = new ComboBox();
            label4 = new Label();
            panel7 = new Panel();
            errUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            label5 = new Label();
            panel8 = new Panel();
            errUnit = new Label();
            txtUnit = new TextBox();
            label7 = new Label();
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
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 72);
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
            tableLayoutPanel2.Size = new Size(459, 72);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(158, 26);
            label1.Name = "label1";
            label1.Size = new Size(142, 19);
            label1.TabIndex = 0;
            label1.Text = "Thông tin dịch vụ";
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 447);
            panel3.Name = "panel3";
            panel3.Size = new Size(459, 51);
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
            tableLayoutPanel1.Size = new Size(459, 51);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnReset
            // 
            btnReset.Anchor = AnchorStyles.None;
            btnReset.BackColor = SystemColors.HotTrack;
            btnReset.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.ForeColor = SystemColors.ButtonHighlight;
            btnReset.Location = new Point(264, 8);
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
            btnSave.Location = new Point(35, 8);
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
            panel2.Size = new Size(459, 375);
            panel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel7);
            flowLayoutPanel1.Controls.Add(panel8);
            flowLayoutPanel1.Location = new Point(3, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(453, 362);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtId);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(450, 52);
            panel4.TabIndex = 0;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(6, 18);
            txtId.Name = "txtId";
            txtId.Size = new Size(435, 23);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã dịch vụ";
            // 
            // panel5
            // 
            panel5.Controls.Add(errName);
            panel5.Controls.Add(txtName);
            panel5.Controls.Add(txt);
            panel5.Location = new Point(3, 61);
            panel5.Name = "panel5";
            panel5.Size = new Size(450, 72);
            panel5.TabIndex = 1;
            // 
            // errName
            // 
            errName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            errName.ForeColor = Color.Red;
            errName.Location = new Point(3, 44);
            errName.Name = "errName";
            errName.Size = new Size(438, 22);
            errName.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(6, 18);
            txtName.Name = "txtName";
            txtName.Size = new Size(435, 23);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txt
            // 
            txt.AutoSize = true;
            txt.Location = new Point(3, 0);
            txt.Name = "txt";
            txt.Size = new Size(67, 15);
            txt.TabIndex = 0;
            txt.Text = "Tên dịch vụ";
            // 
            // panel6
            // 
            panel6.Controls.Add(cbxServiceType);
            panel6.Controls.Add(label4);
            panel6.Location = new Point(3, 139);
            panel6.Name = "panel6";
            panel6.Size = new Size(450, 55);
            panel6.TabIndex = 2;
            // 
            // cbxServiceType
            // 
            cbxServiceType.FormattingEnabled = true;
            cbxServiceType.Location = new Point(6, 18);
            cbxServiceType.Name = "cbxServiceType";
            cbxServiceType.Size = new Size(435, 23);
            cbxServiceType.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 0;
            label4.Text = "Loại dịch vụ";
            // 
            // panel7
            // 
            panel7.Controls.Add(errUnitPrice);
            panel7.Controls.Add(txtUnitPrice);
            panel7.Controls.Add(label5);
            panel7.Location = new Point(3, 200);
            panel7.Name = "panel7";
            panel7.Size = new Size(450, 72);
            panel7.TabIndex = 3;
            // 
            // errUnitPrice
            // 
            errUnitPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            errUnitPrice.ForeColor = Color.Red;
            errUnitPrice.Location = new Point(3, 44);
            errUnitPrice.Name = "errUnitPrice";
            errUnitPrice.Size = new Size(438, 22);
            errUnitPrice.TabIndex = 3;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(6, 18);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(435, 23);
            txtUnitPrice.TabIndex = 1;
            txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 0;
            label5.Text = "Giá dịch vụ";
            // 
            // panel8
            // 
            panel8.Controls.Add(errUnit);
            panel8.Controls.Add(txtUnit);
            panel8.Controls.Add(label7);
            panel8.Location = new Point(3, 278);
            panel8.Name = "panel8";
            panel8.Size = new Size(450, 72);
            panel8.TabIndex = 4;
            // 
            // errUnit
            // 
            errUnit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            errUnit.ForeColor = Color.Red;
            errUnit.Location = new Point(3, 44);
            errUnit.Name = "errUnit";
            errUnit.Size = new Size(438, 22);
            errUnit.TabIndex = 3;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(6, 18);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(435, 23);
            txtUnit.TabIndex = 1;
            txtUnit.TextChanged += txtUnit_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 0;
            label7.Text = "Đơn vị";
            // 
            // ServiceInfoUI
            // 
            ClientSize = new Size(459, 498);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "ServiceInfoUI";
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
        private TextBox txtName;
        private Label txt;
        private Label errName;
        private Panel panel6;
        private Label label4;
        private ComboBox cbxServiceType;
        private Panel panel7;
        private Label errUnitPrice;
        private TextBox txtUnitPrice;
        private Label label5;
        private Panel panel8;
        private Label errUnit;
        private TextBox txtUnit;
        private Label label7;
    }

    #endregion
}
