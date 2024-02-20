namespace HotelManagement.GUI
{
    using HotelManagement.Business;
    using HotelManagement.Data;

    using Org.BouncyCastle.Utilities.IO;

    using System;
    using System.Windows.Forms;

    public partial class StaffImexUI : Form
    {
        public const string ExcelFileFilter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";

        private string fileName;

        public StaffImexUI()
        {
            InitializeComponent();
            StaffImexBO.Instance.LoadData();
            InitDataSource();
            if (!LoginBO.IsPermissionGranted(Permission.WriteStaff))
                btnImport.Visible = false;
            btnSave.Visible = false;
            Text = "Xem trước";
        }

        private void InitDataSource()
        {
            var bo = StaffImexBO.Instance;
            gvdata.DataSource = bo.Data;
            var columns = gvdata.Columns;
            var c = columns.Count;

            for (int i = c; i > 0;)
            {
                var column = columns[--i];
                var name = StaffImexBO.ConvertName(column.DataPropertyName);
                if (name != null) column.HeaderText = name;
                else column.Visible = false;
            }
        }

        private void OnExport(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                CreatePrompt = false,
                Filter = ExcelFileFilter,
                OverwritePrompt = true
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream stream = null;
                try
                {
                    if (!StaffImexBO.Instance.ExportData(stream = sfd.OpenFile()))
                        MessageBox.Show("Xuất file xuất thất bại", "Xuất file Excel", MessageBoxButtons.OK);
                    else MessageBox.Show("Xuất file xuất thành công.", "Xuất file Excel", MessageBoxButtons.OK);
                    stream.Dispose();
                }
                catch (Exception ex)
                {
                    stream?.Dispose();
                    MessageBox.Show(ex.Message, "Xuất file Excel", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void OnImport(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = ExcelFileFilter,
                Multiselect = false
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream stream = null;
                try
                {
                    if (!StaffImexBO.Instance.ImportData(stream = ofd.OpenFile()))
                        MessageBox.Show("Tải file nhập thất bại", "Nhập file Excel", MessageBoxButtons.OK);
                    else MessageBox.Show("Tải file nhập thành công.", "Nhập file Excel", MessageBoxButtons.OK);
                    stream.Dispose();
                }
                catch (Exception ex)
                {
                    stream?.Dispose();
                    MessageBox.Show(ex.Message, "Nhập file Excel", MessageBoxButtons.OK);
                    return;
                }
                Text = "Xem trước khi nhập: File " + fileName;
                btnSave.Visible = true;
            }
        }

        private void OnExportTemplate(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new()
            {
                CreatePrompt = false,
                Filter = ExcelFileFilter,
                OverwritePrompt = true
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream stream = null;
                try
                {
                    if (!StaffImexBO.Instance.ExportTemplate(stream = sfd.OpenFile()))
                        MessageBox.Show("Xuất file mẫu thất bại.", "Xuất file mẫu", MessageBoxButtons.OK);
                    else MessageBox.Show("Xuất file mẫu thành công.", "Xuất file mẫu", MessageBoxButtons.OK);
                    stream.Dispose();
                }
                catch (Exception ex)
                {
                    stream?.Dispose();
                    MessageBox.Show(ex.Message, "Xuất file mẫu", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void OnSave(object sender, EventArgs e)
        {
            StaffImexBO.Instance.SaveChangeAndReload();
            Text = "Xem trước";
            btnSave.Visible = false;
        }
    }
}
