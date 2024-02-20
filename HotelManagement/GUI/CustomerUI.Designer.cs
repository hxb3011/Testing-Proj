namespace HotelManagement.GUI
{
    partial class CustomerUI
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            tableLayoutPanel6 = new TableLayoutPanel();
            mbtnDelFilterID = new MaterialSkin.Controls.MaterialButton();
            cbxFilterID = new ComboBox();
            tabPage8 = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            mcbxDeleteFilterName = new MaterialSkin.Controls.MaterialButton();
            cbxFilterName = new ComboBox();
            tabPage9 = new TabPage();
            tableLayoutPanel7 = new TableLayoutPanel();
            mcbxDeleteFilterGender = new MaterialSkin.Controls.MaterialButton();
            cbxFilterGender = new ComboBox();
            tabPage10 = new TabPage();
            tableLayoutPanel8 = new TableLayoutPanel();
            cbxFilterCCCD = new ComboBox();
            mcbxDeleteFilterCCCD = new MaterialSkin.Controls.MaterialButton();
            tableLayoutPanel5 = new TableLayoutPanel();
            mbtnFilter = new MaterialSkin.Controls.MaterialButton();
            mbtnDeleteAllFilter = new MaterialSkin.Controls.MaterialButton();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            panel5 = new Panel();
            mbtnDeleteCustomer = new MaterialSkin.Controls.MaterialButton();
            mbtnUpdateCustomer = new MaterialSkin.Controls.MaterialButton();
            mbtnAddCustomer = new MaterialSkin.Controls.MaterialButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tabPage8.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tabPage9.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tabPage10.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel5.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.ForeColor = SystemColors.HotTrack;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1260, 564);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(945, 564);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(945, 564);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 165);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(945, 399);
            panel3.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = SystemColors.Desktop;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(945, 399);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Data";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(4, 30);
            dataGridView1.Margin = new Padding(5, 3, 5, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(937, 366);
            dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(945, 165);
            panel2.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(tableLayoutPanel3);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.ForeColor = SystemColors.HotTrack;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Margin = new Padding(4, 3, 4, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 3, 4, 3);
            groupBox3.Size = new Size(945, 165);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Filter";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tabControl2, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(4, 30);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 64F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 36F));
            tableLayoutPanel3.Size = new Size(937, 132);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage8);
            tabControl2.Controls.Add(tabPage9);
            tabControl2.Controls.Add(tabPage10);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 0);
            tabControl2.Margin = new Padding(0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(937, 84);
            tabControl2.TabIndex = 2;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tableLayoutPanel6);
            tabPage4.Location = new Point(4, 37);
            tabPage4.Margin = new Padding(0);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(929, 43);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Mã KH";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.White;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.67F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel6.Controls.Add(mbtnDelFilterID, 1, 0);
            tableLayoutPanel6.Controls.Add(cbxFilterID, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.Padding = new Padding(3, 0, 3, 0);
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(929, 43);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // mbtnDelFilterID
            // 
            mbtnDelFilterID.AutoSize = false;
            mbtnDelFilterID.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnDelFilterID.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnDelFilterID.Depth = 0;
            mbtnDelFilterID.Dock = DockStyle.Fill;
            mbtnDelFilterID.HighEmphasis = true;
            mbtnDelFilterID.Icon = null;
            mbtnDelFilterID.Location = new Point(622, 6);
            mbtnDelFilterID.Margin = new Padding(4, 6, 4, 6);
            mbtnDelFilterID.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnDelFilterID.Name = "mbtnDelFilterID";
            mbtnDelFilterID.NoAccentTextColor = Color.Empty;
            mbtnDelFilterID.Size = new Size(300, 31);
            mbtnDelFilterID.TabIndex = 3;
            mbtnDelFilterID.Text = "Xóa";
            mbtnDelFilterID.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnDelFilterID.UseAccentColor = false;
            mbtnDelFilterID.UseVisualStyleBackColor = true;
            mbtnDelFilterID.Click += mbtnDelFilterID_Click;
            // 
            // cbxFilterID
            // 
            cbxFilterID.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxFilterID.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxFilterID.Dock = DockStyle.Fill;
            cbxFilterID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxFilterID.FormattingEnabled = true;
            cbxFilterID.Location = new Point(7, 6);
            cbxFilterID.Margin = new Padding(4, 6, 4, 6);
            cbxFilterID.Name = "cbxFilterID";
            cbxFilterID.Size = new Size(607, 36);
            cbxFilterID.TabIndex = 4;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(tableLayoutPanel4);
            tabPage8.Location = new Point(4, 29);
            tabPage8.Margin = new Padding(0);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(929, 55);
            tabPage8.TabIndex = 2;
            tabPage8.Text = "Tên KH";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.White;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.67F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel4.Controls.Add(mcbxDeleteFilterName, 1, 0);
            tableLayoutPanel4.Controls.Add(cbxFilterName, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(929, 55);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // mcbxDeleteFilterName
            // 
            mcbxDeleteFilterName.AutoSize = false;
            mcbxDeleteFilterName.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mcbxDeleteFilterName.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mcbxDeleteFilterName.Depth = 0;
            mcbxDeleteFilterName.Dock = DockStyle.Fill;
            mcbxDeleteFilterName.HighEmphasis = true;
            mcbxDeleteFilterName.Icon = null;
            mcbxDeleteFilterName.Location = new Point(622, 5);
            mcbxDeleteFilterName.Margin = new Padding(3, 5, 3, 5);
            mcbxDeleteFilterName.MouseState = MaterialSkin.MouseState.HOVER;
            mcbxDeleteFilterName.Name = "mcbxDeleteFilterName";
            mcbxDeleteFilterName.NoAccentTextColor = Color.Empty;
            mcbxDeleteFilterName.Size = new Size(304, 45);
            mcbxDeleteFilterName.TabIndex = 4;
            mcbxDeleteFilterName.Text = "Xóa";
            mcbxDeleteFilterName.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mcbxDeleteFilterName.UseAccentColor = false;
            mcbxDeleteFilterName.UseVisualStyleBackColor = true;
            mcbxDeleteFilterName.Click += mcbxDeleteFilterName_Click;
            // 
            // cbxFilterName
            // 
            cbxFilterName.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxFilterName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxFilterName.Dock = DockStyle.Fill;
            cbxFilterName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxFilterName.FormattingEnabled = true;
            cbxFilterName.Location = new Point(3, 5);
            cbxFilterName.Margin = new Padding(3, 5, 3, 5);
            cbxFilterName.Name = "cbxFilterName";
            cbxFilterName.Size = new Size(613, 36);
            cbxFilterName.TabIndex = 5;
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(tableLayoutPanel7);
            tabPage9.Location = new Point(4, 29);
            tabPage9.Margin = new Padding(0);
            tabPage9.Name = "tabPage9";
            tabPage9.Size = new Size(929, 55);
            tabPage9.TabIndex = 3;
            tabPage9.Text = "Giới Tính";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.BackColor = Color.White;
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.67F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel7.Controls.Add(mcbxDeleteFilterGender, 1, 0);
            tableLayoutPanel7.Controls.Add(cbxFilterGender, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(929, 55);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // mcbxDeleteFilterGender
            // 
            mcbxDeleteFilterGender.AutoSize = false;
            mcbxDeleteFilterGender.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mcbxDeleteFilterGender.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mcbxDeleteFilterGender.Depth = 0;
            mcbxDeleteFilterGender.Dock = DockStyle.Fill;
            mcbxDeleteFilterGender.HighEmphasis = true;
            mcbxDeleteFilterGender.Icon = null;
            mcbxDeleteFilterGender.Location = new Point(622, 5);
            mcbxDeleteFilterGender.Margin = new Padding(3, 5, 3, 5);
            mcbxDeleteFilterGender.MouseState = MaterialSkin.MouseState.HOVER;
            mcbxDeleteFilterGender.Name = "mcbxDeleteFilterGender";
            mcbxDeleteFilterGender.NoAccentTextColor = Color.Empty;
            mcbxDeleteFilterGender.Size = new Size(304, 45);
            mcbxDeleteFilterGender.TabIndex = 5;
            mcbxDeleteFilterGender.Text = "Xóa";
            mcbxDeleteFilterGender.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mcbxDeleteFilterGender.UseAccentColor = false;
            mcbxDeleteFilterGender.UseVisualStyleBackColor = true;
            mcbxDeleteFilterGender.Click += mcbxDeleteFilterGender_Click;
            // 
            // cbxFilterGender
            // 
            cbxFilterGender.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxFilterGender.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxFilterGender.Dock = DockStyle.Fill;
            cbxFilterGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxFilterGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxFilterGender.FormattingEnabled = true;
            cbxFilterGender.Location = new Point(3, 5);
            cbxFilterGender.Margin = new Padding(3, 5, 3, 5);
            cbxFilterGender.Name = "cbxFilterGender";
            cbxFilterGender.Size = new Size(613, 36);
            cbxFilterGender.TabIndex = 5;
            // 
            // tabPage10
            // 
            tabPage10.Controls.Add(tableLayoutPanel8);
            tabPage10.Location = new Point(4, 29);
            tabPage10.Margin = new Padding(0);
            tabPage10.Name = "tabPage10";
            tabPage10.Size = new Size(929, 55);
            tabPage10.TabIndex = 4;
            tabPage10.Text = "CCCD";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.BackColor = Color.White;
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.67F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel8.Controls.Add(cbxFilterCCCD, 0, 0);
            tableLayoutPanel8.Controls.Add(mcbxDeleteFilterCCCD, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(929, 55);
            tableLayoutPanel8.TabIndex = 3;
            // 
            // cbxFilterCCCD
            // 
            cbxFilterCCCD.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxFilterCCCD.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbxFilterCCCD.Dock = DockStyle.Fill;
            cbxFilterCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxFilterCCCD.FormattingEnabled = true;
            cbxFilterCCCD.Location = new Point(3, 5);
            cbxFilterCCCD.Margin = new Padding(3, 5, 3, 5);
            cbxFilterCCCD.Name = "cbxFilterCCCD";
            cbxFilterCCCD.Size = new Size(613, 36);
            cbxFilterCCCD.TabIndex = 5;
            // 
            // mcbxDeleteFilterCCCD
            // 
            mcbxDeleteFilterCCCD.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mcbxDeleteFilterCCCD.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mcbxDeleteFilterCCCD.Depth = 0;
            mcbxDeleteFilterCCCD.Dock = DockStyle.Fill;
            mcbxDeleteFilterCCCD.HighEmphasis = true;
            mcbxDeleteFilterCCCD.Icon = null;
            mcbxDeleteFilterCCCD.Location = new Point(622, 5);
            mcbxDeleteFilterCCCD.Margin = new Padding(3, 5, 3, 5);
            mcbxDeleteFilterCCCD.MouseState = MaterialSkin.MouseState.HOVER;
            mcbxDeleteFilterCCCD.Name = "mcbxDeleteFilterCCCD";
            mcbxDeleteFilterCCCD.NoAccentTextColor = Color.Empty;
            mcbxDeleteFilterCCCD.Size = new Size(304, 45);
            mcbxDeleteFilterCCCD.TabIndex = 6;
            mcbxDeleteFilterCCCD.Text = "Xóa";
            mcbxDeleteFilterCCCD.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mcbxDeleteFilterCCCD.UseAccentColor = false;
            mcbxDeleteFilterCCCD.UseVisualStyleBackColor = true;
            mcbxDeleteFilterCCCD.Click += mcbxDeleteFilterCCCD_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(mbtnFilter, 1, 0);
            tableLayoutPanel5.Controls.Add(mbtnDeleteAllFilter, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 84);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(937, 48);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // mbtnFilter
            // 
            mbtnFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnFilter.Depth = 0;
            mbtnFilter.Dock = DockStyle.Fill;
            mbtnFilter.HighEmphasis = true;
            mbtnFilter.Icon = null;
            mbtnFilter.Location = new Point(472, 6);
            mbtnFilter.Margin = new Padding(4, 6, 10, 6);
            mbtnFilter.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnFilter.Name = "mbtnFilter";
            mbtnFilter.NoAccentTextColor = Color.Empty;
            mbtnFilter.Size = new Size(455, 36);
            mbtnFilter.TabIndex = 5;
            mbtnFilter.Text = "LỌC";
            mbtnFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnFilter.UseAccentColor = false;
            mbtnFilter.UseVisualStyleBackColor = true;
            mbtnFilter.Click += mbtnFilter_Click;
            // 
            // mbtnDeleteAllFilter
            // 
            mbtnDeleteAllFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnDeleteAllFilter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnDeleteAllFilter.Depth = 0;
            mbtnDeleteAllFilter.Dock = DockStyle.Fill;
            mbtnDeleteAllFilter.HighEmphasis = true;
            mbtnDeleteAllFilter.Icon = null;
            mbtnDeleteAllFilter.Location = new Point(10, 6);
            mbtnDeleteAllFilter.Margin = new Padding(10, 6, 4, 6);
            mbtnDeleteAllFilter.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnDeleteAllFilter.Name = "mbtnDeleteAllFilter";
            mbtnDeleteAllFilter.NoAccentTextColor = Color.Empty;
            mbtnDeleteAllFilter.Size = new Size(454, 36);
            mbtnDeleteAllFilter.TabIndex = 4;
            mbtnDeleteAllFilter.Text = "Xóa tất cả";
            mbtnDeleteAllFilter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnDeleteAllFilter.UseAccentColor = false;
            mbtnDeleteAllFilter.UseVisualStyleBackColor = true;
            mbtnDeleteAllFilter.Click += mbtnDeleteAllFilter_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(945, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(315, 564);
            panel4.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(panel5);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = SystemColors.HotTrack;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(315, 564);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // panel5
            // 
            panel5.Controls.Add(mbtnDeleteCustomer);
            panel5.Controls.Add(mbtnUpdateCustomer);
            panel5.Controls.Add(mbtnAddCustomer);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(4, 30);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(3);
            panel5.Size = new Size(307, 531);
            panel5.TabIndex = 0;
            // 
            // mbtnDeleteCustomer
            // 
            mbtnDeleteCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mbtnDeleteCustomer.AutoSize = false;
            mbtnDeleteCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnDeleteCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnDeleteCustomer.Depth = 0;
            mbtnDeleteCustomer.HighEmphasis = true;
            mbtnDeleteCustomer.Icon = null;
            mbtnDeleteCustomer.Location = new Point(6, 102);
            mbtnDeleteCustomer.Margin = new Padding(3, 5, 6, 5);
            mbtnDeleteCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnDeleteCustomer.Name = "mbtnDeleteCustomer";
            mbtnDeleteCustomer.NoAccentTextColor = Color.Empty;
            mbtnDeleteCustomer.Size = new Size(292, 37);
            mbtnDeleteCustomer.TabIndex = 8;
            mbtnDeleteCustomer.Text = "XÓA KHÁCH HÀNG";
            mbtnDeleteCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            mbtnDeleteCustomer.UseAccentColor = false;
            mbtnDeleteCustomer.UseVisualStyleBackColor = true;
            mbtnDeleteCustomer.Click += mbtnDeleteCustomer_Click;
            // 
            // mbtnUpdateCustomer
            // 
            mbtnUpdateCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mbtnUpdateCustomer.AutoSize = false;
            mbtnUpdateCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnUpdateCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnUpdateCustomer.Depth = 0;
            mbtnUpdateCustomer.HighEmphasis = true;
            mbtnUpdateCustomer.Icon = null;
            mbtnUpdateCustomer.Location = new Point(6, 55);
            mbtnUpdateCustomer.Margin = new Padding(3, 5, 6, 5);
            mbtnUpdateCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnUpdateCustomer.Name = "mbtnUpdateCustomer";
            mbtnUpdateCustomer.NoAccentTextColor = Color.Empty;
            mbtnUpdateCustomer.Size = new Size(292, 37);
            mbtnUpdateCustomer.TabIndex = 7;
            mbtnUpdateCustomer.Text = "cập nhật KHÁCH HÀNG";
            mbtnUpdateCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnUpdateCustomer.UseAccentColor = true;
            mbtnUpdateCustomer.UseVisualStyleBackColor = true;
            mbtnUpdateCustomer.Click += mbtnUpdateCustomer_Click;
            // 
            // mbtnAddCustomer
            // 
            mbtnAddCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mbtnAddCustomer.AutoSize = false;
            mbtnAddCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mbtnAddCustomer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            mbtnAddCustomer.Depth = 0;
            mbtnAddCustomer.HighEmphasis = true;
            mbtnAddCustomer.Icon = null;
            mbtnAddCustomer.Location = new Point(6, 8);
            mbtnAddCustomer.Margin = new Padding(3, 5, 6, 5);
            mbtnAddCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            mbtnAddCustomer.Name = "mbtnAddCustomer";
            mbtnAddCustomer.NoAccentTextColor = Color.Empty;
            mbtnAddCustomer.Size = new Size(292, 37);
            mbtnAddCustomer.TabIndex = 6;
            mbtnAddCustomer.Text = "THÊM KHÁCH HÀNG";
            mbtnAddCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            mbtnAddCustomer.UseAccentColor = false;
            mbtnAddCustomer.UseVisualStyleBackColor = true;
            mbtnAddCustomer.Click += mbtnAddCustomer_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1274, 611);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1266, 570);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Customer";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // CustomerUI
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 611);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "CustomerUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerUI";
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tabPage8.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tabPage9.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tabPage10.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Panel panel2;
        private GroupBox groupBox3;
        private TableLayoutPanel tableLayoutPanel3;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private TableLayoutPanel tableLayoutPanel6;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel panel4;
        private GroupBox groupBox1;
        private Panel panel5;
        private ComboBox cbxFilterID;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private ComboBox cbxFilterName;
        private ComboBox cbxFilterGender;
        private ComboBox cbxFilterCCCD;
        private MaterialSkin.Controls.MaterialButton mbtnDelFilterID;
        private MaterialSkin.Controls.MaterialButton mbtnDeleteAllFilter;
        private MaterialSkin.Controls.MaterialButton mbtnFilter;
        private MaterialSkin.Controls.MaterialButton mcbxDeleteFilterName;
        private MaterialSkin.Controls.MaterialButton mcbxDeleteFilterGender;
        private MaterialSkin.Controls.MaterialButton mcbxDeleteFilterCCCD;
        private MaterialSkin.Controls.MaterialButton mbtnAddCustomer;
        private MaterialSkin.Controls.MaterialButton mbtnUpdateCustomer;
        private MaterialSkin.Controls.MaterialButton mbtnDeleteCustomer;
        private TabControl tabControl1;
        private TabPage tabPage1;
    }
}