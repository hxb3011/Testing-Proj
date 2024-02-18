using System.Windows.Forms;

namespace HotelManagement.GUI
{
    partial class ReservBookingUI
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
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            panel1 = new Panel();
            panelGender = new Panel();
            radioBtnMale = new MaterialSkin.Controls.MaterialRadioButton();
            radioBtnFemale = new MaterialSkin.Controls.MaterialRadioButton();
            txtId = new MaterialSkin.Controls.MaterialTextBox();
            txtName = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            txtPhone = new MaterialSkin.Controls.MaterialTextBox();
            txtCCCD = new MaterialSkin.Controls.MaterialTextBox();
            labelDontExist = new MaterialSkin.Controls.MaterialLabel();
            btnAddCustomer = new MaterialSkin.Controls.MaterialButton();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            panel2 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            panel7 = new Panel();
            fromTime = new DateTimePicker();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            panel5 = new Panel();
            tableRoom = new DataGridView();
            materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            panel4 = new Panel();
            tableBook = new DataGridView();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            panel3 = new Panel();
            toTime = new DateTimePicker();
            materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            panel6 = new Panel();
            btnCancel = new MaterialSkin.Controls.MaterialButton();
            btnSave = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panelGender.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableRoom).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableBook).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel6, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 64);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(1232, 701);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Controls.Add(materialLabel2, 0, 0);
            tableLayoutPanel2.Controls.Add(materialLabel3, 1, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 1, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(61, 10);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1108, 641);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Dock = DockStyle.Fill;
            materialLabel2.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel2.ForeColor = SystemColors.ControlText;
            materialLabel2.Location = new Point(3, 3);
            materialLabel2.Margin = new Padding(3, 3, 3, 3);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(326, 34);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Customer Information";
            materialLabel2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Dock = DockStyle.Fill;
            materialLabel3.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            materialLabel3.Location = new Point(335, 3);
            materialLabel3.Margin = new Padding(3, 3, 3, 3);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(770, 34);
            materialLabel3.TabIndex = 3;
            materialLabel3.Text = "Room Information";
            materialLabel3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(panelGender);
            panel1.Controls.Add(txtId);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(materialLabel8);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtCCCD);
            panel1.Controls.Add(labelDontExist);
            panel1.Controls.Add(btnAddCustomer);
            panel1.Controls.Add(materialLabel6);
            panel1.Controls.Add(materialLabel5);
            panel1.Controls.Add(materialLabel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 40);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(15, 15, 15, 15);
            panel1.Size = new Size(332, 601);
            panel1.TabIndex = 4;
            // 
            // panelGender
            // 
            panelGender.Controls.Add(radioBtnMale);
            panelGender.Controls.Add(radioBtnFemale);
            panelGender.Enabled = false;
            panelGender.Location = new Point(138, 296);
            panelGender.Margin = new Padding(3, 2, 3, 2);
            panelGender.Name = "panelGender";
            panelGender.Size = new Size(173, 44);
            panelGender.TabIndex = 22;
            // 
            // radioBtnMale
            // 
            radioBtnMale.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioBtnMale.AutoSize = true;
            radioBtnMale.Checked = true;
            radioBtnMale.Depth = 0;
            radioBtnMale.Location = new Point(-4, 10);
            radioBtnMale.Margin = new Padding(0);
            radioBtnMale.MouseLocation = new Point(-1, -1);
            radioBtnMale.MouseState = MaterialSkin.MouseState.HOVER;
            radioBtnMale.Name = "radioBtnMale";
            radioBtnMale.Ripple = true;
            radioBtnMale.Size = new Size(70, 37);
            radioBtnMale.TabIndex = 8;
            radioBtnMale.TabStop = true;
            radioBtnMale.Text = "Male";
            radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // radioBtnFemale
            // 
            radioBtnFemale.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioBtnFemale.AutoSize = true;
            radioBtnFemale.Depth = 0;
            radioBtnFemale.Location = new Point(65, 10);
            radioBtnFemale.Margin = new Padding(0);
            radioBtnFemale.MouseLocation = new Point(-1, -1);
            radioBtnFemale.MouseState = MaterialSkin.MouseState.HOVER;
            radioBtnFemale.Name = "radioBtnFemale";
            radioBtnFemale.Ripple = true;
            radioBtnFemale.Size = new Size(87, 37);
            radioBtnFemale.TabIndex = 9;
            radioBtnFemale.TabStop = true;
            radioBtnFemale.Text = "Female";
            radioBtnFemale.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtId.AnimateReadOnly = false;
            txtId.BorderStyle = BorderStyle.None;
            txtId.Depth = 0;
            txtId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.LeadingIcon = null;
            txtId.Location = new Point(15, 44);
            txtId.MaxLength = 50;
            txtId.MouseState = MaterialSkin.MouseState.OUT;
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(300, 50);
            txtId.TabIndex = 21;
            txtId.Text = "";
            txtId.TrailingIcon = null;
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.AnimateReadOnly = false;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Depth = 0;
            txtName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.LeadingIcon = null;
            txtName.Location = new Point(18, 355);
            txtName.MaxLength = 50;
            txtName.MouseState = MaterialSkin.MouseState.OUT;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(297, 50);
            txtName.TabIndex = 20;
            txtName.Text = "";
            txtName.TrailingIcon = null;
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel8.Location = new Point(15, 15);
            materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(160, 24);
            materialLabel8.TabIndex = 7;
            materialLabel8.Text = "RESERVATION ID:";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.AnimateReadOnly = false;
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Depth = 0;
            txtPhone.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPhone.LeadingIcon = null;
            txtPhone.Location = new Point(15, 246);
            txtPhone.MaxLength = 50;
            txtPhone.MouseState = MaterialSkin.MouseState.OUT;
            txtPhone.Multiline = false;
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(297, 50);
            txtPhone.TabIndex = 19;
            txtPhone.Text = "";
            txtPhone.TrailingIcon = null;
            // 
            // txtCCCD
            // 
            txtCCCD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCCCD.AnimateReadOnly = false;
            txtCCCD.BorderStyle = BorderStyle.None;
            txtCCCD.Depth = 0;
            txtCCCD.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCCCD.LeadingIcon = null;
            txtCCCD.Location = new Point(15, 144);
            txtCCCD.MaxLength = 50;
            txtCCCD.MouseState = MaterialSkin.MouseState.OUT;
            txtCCCD.Multiline = false;
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(297, 50);
            txtCCCD.TabIndex = 18;
            txtCCCD.Text = "";
            txtCCCD.TrailingIcon = null;
            txtCCCD.TextChanged += txtCCCD_TextChanged;
            // 
            // labelDontExist
            // 
            labelDontExist.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDontExist.AutoSize = true;
            labelDontExist.Depth = 0;
            labelDontExist.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelDontExist.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            labelDontExist.Location = new Point(18, 424);
            labelDontExist.MouseState = MaterialSkin.MouseState.HOVER;
            labelDontExist.Name = "labelDontExist";
            labelDontExist.Size = new Size(104, 24);
            labelDontExist.TabIndex = 13;
            labelDontExist.Text = "Don't Exist?";
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddCustomer.Depth = 0;
            btnAddCustomer.HighEmphasis = true;
            btnAddCustomer.Icon = null;
            btnAddCustomer.Location = new Point(146, 416);
            btnAddCustomer.Margin = new Padding(4, 6, 4, 6);
            btnAddCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.NoAccentTextColor = Color.Empty;
            btnAddCustomer.Size = new Size(169, 36);
            btnAddCustomer.TabIndex = 11;
            btnAddCustomer.Text = "Add Customer Info";
            btnAddCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddCustomer.UseAccentColor = false;
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel6.Location = new Point(18, 322);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(62, 24);
            materialLabel6.TabIndex = 5;
            materialLabel6.Text = "NAME:";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel5.Location = new Point(15, 214);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(72, 24);
            materialLabel5.TabIndex = 3;
            materialLabel5.Text = "PHONE:";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel1.Location = new Point(15, 112);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(104, 24);
            materialLabel1.TabIndex = 0;
            materialLabel1.Text = "CITIZEN ID:";
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(332, 40);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 601);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(panel7, 0, 0);
            tableLayoutPanel4.Controls.Add(panel5, 0, 1);
            tableLayoutPanel4.Controls.Add(panel4, 0, 1);
            tableLayoutPanel4.Controls.Add(panel3, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(776, 601);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(fromTime);
            panel7.Controls.Add(materialLabel4);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(15, 15, 15, 15);
            panel7.Size = new Size(388, 48);
            panel7.TabIndex = 16;
            // 
            // fromTime
            // 
            fromTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fromTime.CustomFormat = "dd/MM/yyyy";
            fromTime.Format = DateTimePickerFormat.Custom;
            fromTime.Location = new Point(85, 16);
            fromTime.Name = "fromTime";
            fromTime.Size = new Size(286, 23);
            fromTime.TabIndex = 15;
            fromTime.ValueChanged += fromTime_ValueChanged;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel4.Location = new Point(18, 15);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(61, 24);
            materialLabel4.TabIndex = 14;
            materialLabel4.Text = "FROM:";
            // 
            // panel5
            // 
            panel5.Controls.Add(tableRoom);
            panel5.Controls.Add(materialLabel11);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 48);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(18, 15, 18, 15);
            panel5.Size = new Size(388, 553);
            panel5.TabIndex = 3;
            // 
            // tableRoom
            // 
            tableRoom.AllowUserToAddRows = false;
            tableRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableRoom.BackgroundColor = SystemColors.Control;
            tableRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableRoom.Dock = DockStyle.Fill;
            tableRoom.Location = new Point(18, 39);
            tableRoom.MultiSelect = false;
            tableRoom.Name = "tableRoom";
            tableRoom.ReadOnly = true;
            tableRoom.RightToLeft = RightToLeft.No;
            tableRoom.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tableRoom.RowHeadersVisible = false;
            tableRoom.RowHeadersWidth = 51;
            tableRoom.RowTemplate.Height = 25;
            tableRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableRoom.Size = new Size(352, 499);
            tableRoom.TabIndex = 16;
            tableRoom.CellContentClick += tableRoom_CellContentClick;
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Dock = DockStyle.Top;
            materialLabel11.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel11.Location = new Point(18, 15);
            materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(173, 24);
            materialLabel11.TabIndex = 15;
            materialLabel11.Text = "AVAILABLE ROOM:";
            // 
            // panel4
            // 
            panel4.Controls.Add(tableBook);
            panel4.Controls.Add(materialLabel10);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(388, 48);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(18, 15, 18, 15);
            panel4.Size = new Size(388, 553);
            panel4.TabIndex = 2;
            // 
            // tableBook
            // 
            tableBook.AllowUserToAddRows = false;
            tableBook.BackgroundColor = SystemColors.Control;
            tableBook.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableBook.Dock = DockStyle.Fill;
            tableBook.Location = new Point(18, 39);
            tableBook.MultiSelect = false;
            tableBook.Name = "tableBook";
            tableBook.ReadOnly = true;
            tableBook.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            tableBook.RowHeadersVisible = false;
            tableBook.RowHeadersWidth = 51;
            tableBook.RowTemplate.Height = 25;
            tableBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableBook.Size = new Size(352, 499);
            tableBook.TabIndex = 15;
            tableBook.CellContentClick += tableBook_CellContentClick;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.Depth = 0;
            materialLabel10.Dock = DockStyle.Top;
            materialLabel10.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel10.Location = new Point(18, 15);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(163, 24);
            materialLabel10.TabIndex = 14;
            materialLabel10.Text = "SELECTED ROOM:";
            // 
            // panel3
            // 
            panel3.Controls.Add(toTime);
            panel3.Controls.Add(materialLabel9);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(388, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(15, 15, 15, 15);
            panel3.Size = new Size(388, 48);
            panel3.TabIndex = 15;
            // 
            // toTime
            // 
            toTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toTime.CustomFormat = "dd/MM/yyyy";
            toTime.Format = DateTimePickerFormat.Custom;
            toTime.Location = new Point(56, 16);
            toTime.Name = "toTime";
            toTime.Size = new Size(316, 23);
            toTime.TabIndex = 16;
            toTime.ValueChanged += toTime_ValueChanged;
            // 
            // materialLabel9
            // 
            materialLabel9.AutoSize = true;
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            materialLabel9.Location = new Point(18, 15);
            materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(32, 24);
            materialLabel9.TabIndex = 16;
            materialLabel9.Text = "TO:";
            // 
            // panel6
            // 
            panel6.Controls.Add(btnCancel);
            panel6.Controls.Add(btnSave);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(61, 651);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1108, 50);
            panel6.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.AutoSize = false;
            btnCancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancel.Depth = 0;
            btnCancel.HighEmphasis = true;
            btnCancel.Icon = null;
            btnCancel.Location = new Point(932, 6);
            btnCancel.Margin = new Padding(4, 6, 4, 6);
            btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancel.Name = "btnCancel";
            btnCancel.NoAccentTextColor = Color.Empty;
            btnCancel.Size = new Size(158, 36);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "CANCEL";
            btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            btnCancel.UseAccentColor = true;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.AutoSize = false;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.Location = new Point(765, 6);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(158, 36);
            btnSave.TabIndex = 0;
            btnSave.Text = "SAVE";
            btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ReservBookingUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1238, 768);
            Controls.Add(tableLayoutPanel1);
            Name = "ReservBookingUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ROOM BOOKING";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelGender.ResumeLayout(false);
            panelGender.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableRoom).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tableBook).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialRadioButton radioBtnMale;
        private MaterialSkin.Controls.MaterialRadioButton radioBtnFemale;
        private MaterialSkin.Controls.MaterialButton btnAddCustomer;
        private MaterialSkin.Controls.MaterialLabel labelDontExist;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel6;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private Panel panel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private Panel panel5;
        private DataGridView tableRoom;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private Panel panel4;
        private DataGridView tableBook;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private Panel panel3;
        private DateTimePicker toTime;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private MaterialSkin.Controls.MaterialTextBox txtPhone;
        private MaterialSkin.Controls.MaterialTextBox txtCCCD;
        private DateTimePicker fromTime;
        private MaterialSkin.Controls.MaterialTextBox txtId;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private Panel panelGender;
    }
}