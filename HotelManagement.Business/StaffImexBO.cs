namespace HotelManagement.Business
{
    using HotelManagement.Data;
    using HotelManagement.Data.Access;

    using OfficeOpenXml;
    using OfficeOpenXml.Style;

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.IO.Packaging;
    using System.Numerics;
    using System.Reflection;
    using System.Windows.Forms;

    public class StaffImexBO
    {
        private static readonly string[] columnNames = new string[]
        {
                "Họ và tên", "Giới tính", "Ngày sinh", "CCCD/CMND",
                "Địa chỉ", "Số điện thoại", "Lương"
        };

        private static object syncKey = new();
        private static StaffImexBO? bo;

        static StaffImexBO()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private BindingSource data = new(new List<Staff>(), null);

        public static StaffImexBO Instance
        {
            get
            {
                if (bo == null)
                    lock (syncKey)
                    {
                        bo ??= new StaffImexBO();
                    }
                return bo;
            }
        }

        public IEnumerable Data => data;

        private static void ApplyProperties(OfficeProperties props)
        {
            props.Author = "";
            props.Company = Assembly.GetExecutingAssembly()
                .GetCustomAttribute<AssemblyCompanyAttribute>()?.Company ?? nameof(HotelManagement);
            props.Title = "Danh sách nhân viên";
        }

        private static void ApplyDefaultCellStyles(ExcelRange cells)
        {
            var style = cells.Style;

            var font = SystemFonts.DefaultFont;
            style.Font.SetFromFont(font.Name, 14);
            cells.EntireColumn.Width = 28;
        }

        private static void FillTitle(ExcelRange cells, ref int rowIndex)
        {
            cells[2, 1].Value = "Danh sách nhân viên";

            var mcells = cells[2, 1, 2, columnNames.Length];
            mcells.Merge = true;

            var mcstyle = mcells.Style;
            mcstyle.Font.Bold = true;
            mcstyle.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            rowIndex += 3;
        }

        private static void FillHeader(ExcelRange cells, ref int rowIndex)
        {
            //tạo các header từ column header đã tạo từ bên trên
            for (int i = 0, c = columnNames.Length; i < c;)
            {
                string? item = columnNames[i];
                var cell = cells[rowIndex, ++i];

                cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                var fill = cell.Style.Fill;
                fill.PatternType = ExcelFillStyle.Solid;
                fill.BackgroundColor.SetColor(Color.WhiteSmoke);

                var border = cell.Style.Border;
                border.BorderAround(ExcelBorderStyle.Thin);

                cell.Value = item;
            }
            ++rowIndex;
        }

        private static void FillCellWithBorder(ExcelRange cell, object value)
        {
            cell.Style.Border.BorderAround(ExcelBorderStyle.Thin);
            cell.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            cell.Value = value;
        }

        private void FillTemplate(ExcelRange cells, int rowIndex)
        {
            for (int i = 0, c = 10, colIndex = 0; i < c; ++i, ++rowIndex, colIndex = 0)
            {
                FillCellWithBorder(cells[rowIndex, ++colIndex], "");
                FillCellWithBorder(cells[rowIndex, ++colIndex], "");
                FillCellWithBorder(cells[rowIndex, ++colIndex], "");
                FillCellWithBorder(cells[rowIndex, ++colIndex], "");
                FillCellWithBorder(cells[rowIndex, ++colIndex], "");
                FillCellWithBorder(cells[rowIndex, ++colIndex], "");
                FillCellWithBorder(cells[rowIndex, ++colIndex], "");
            }
        }

        private void FillData(ExcelRange cells, int rowIndex)
        {
            var staffs = data.List;
            for (int i = 0, c = staffs.Count, colIndex = 0; i < c; ++i, ++rowIndex, colIndex = 0)
            {
                var sa = (Staff)staffs[i]!;
                FillCellWithBorder(cells[rowIndex, ++colIndex], sa.FullName);
                FillCellWithBorder(cells[rowIndex, ++colIndex], sa.GenderString);
                FillCellWithBorder(cells[rowIndex, ++colIndex], sa.Birthday.ToString(CultureInfo.CurrentCulture));
                FillCellWithBorder(cells[rowIndex, ++colIndex], sa.CitizenId);
                FillCellWithBorder(cells[rowIndex, ++colIndex], sa.Address);
                FillCellWithBorder(cells[rowIndex, ++colIndex], sa.Phone);
                FillCellWithBorder(cells[rowIndex, ++colIndex], sa.Salary.ToString(CultureInfo.CurrentCulture));
            }
        }

        private static void FillWorksheet(ExcelWorksheets ws, string name, Action<ExcelRange, int> fillCellValue)
        {
            var cells = ws.Add(name).Cells;
            ApplyDefaultCellStyles(cells);
            int rowIndex = 1;
            FillTitle(cells, ref rowIndex);
            FillHeader(cells, ref rowIndex);
            fillCellValue(cells, rowIndex);
        }

        private static bool ExportStaffGeneric(Stream stream, string name, Action<ExcelRange, int> fillCellValue)
        {
            ExcelPackage? ep = null;
            try
            {
                ep = new ExcelPackage();
                var wb = ep.Workbook;
                ApplyProperties(wb.Properties);
                FillWorksheet(wb.Worksheets, name, fillCellValue);
                ep.SaveAs(stream);
                ep.Dispose();
                return true;
            }
            catch (Exception)
            {
                ep?.Dispose();
                return false;
            }
        }

        public bool ExportTemplate(Stream stream)
            => ExportStaffGeneric(stream, "Danh sách mẫu", FillTemplate);

        public bool ExportData(Stream stream)
            => ExportStaffGeneric(stream, "Danh sách nhân viên", FillData);

        private int[] DetectColumnOrder(ExcelRange cells)
        {
            int c = columnNames.Length;
            int[] order = new int[c];
            for (int j = 0; j < c; ++j)
            {
                for (int i = 1; i <= c; ++i)
                {
                    if (columnNames[j].Equals(cells[4, i].Value))
                    {
                        order[j] = i;
                        break;
                    }
                }
            }
            return order;
        }

        private static string GetString(object? o)
            => o?.ToString() ?? string.Empty;

        private bool GetData(ExcelRange cells, int i,
            int[] cm, ref string fullName, ref bool gender,
            ref DateOnly birthday, ref string citizenId,
            ref string address, ref string phone, ref double salary)
        {
            var j = 0;
            var bo = StaffManagerBO.Instance;
            var v = GetString(cells[i, cm[j++]].Value);
            if (!bo.IsValidName(v)) return false;
            //MessageBox.Show(v + " |:FullName Passed");
            fullName = v;
            v = GetString(cells[i, cm[j++]].Value);
            if (Staff.GenderMaleString.Equals(v)) gender = Staff.GenderMale;
            else if (Staff.GenderFemaleString.Equals(v)) gender = Staff.GenderFemale;
            else return false;
            //MessageBox.Show(v + " |:Gender Passed");
            v = GetString(cells[i, cm[j++]].Value);
            if (!DateOnly.TryParse(v, CultureInfo.CurrentCulture,
                DateTimeStyles.AllowWhiteSpaces, out birthday))
                return false;
            //MessageBox.Show(v + " |:Birthday Passed");
            v = GetString(cells[i, cm[j++]].Value);
            if (!bo.IsValidCitizenId(v)) return false;
            citizenId = v;
            //MessageBox.Show(v + " |:CitizenId Passed");
            v = GetString(cells[i, cm[j++]].Value);
            if (!bo.IsValidAddress(v)) return false;
            address = v;
            //MessageBox.Show(v + " |:Address Passed");
            v = GetString(cells[i, cm[j++]].Value);
            if (!bo.IsValidPhone(v)) return false;
            phone = v;
            //MessageBox.Show(v + " |:Phone Passed");
            v = GetString(cells[i, cm[j++]].Value);
            if (!double.TryParse(v, NumberStyles.Any,
                CultureInfo.CurrentCulture, out salary))
                return false;
            //MessageBox.Show(v + " |:Row Passed" + i);
            return true;
        }

        private bool IsDuplicated(string citizenId)
        {
            for (int i = 0, c = data.Count; i < c; ++i)
                if (data[i] is Staff sa && sa.CitizenId == citizenId)
                    return true;
            return false;
        }

        public bool ImportData(Stream stream)
        {
            bool cleared = false;
            ExcelPackage? ep = null;
            try
            {
                ep = new ExcelPackage(stream);
                var ws = ep.Workbook.Worksheets.FirstOrDefault();
                if (ws == null) goto close;
                var dims = ws.Dimension;
                var start = dims.Start;
                var end = dims.End;
                var cells = ws.Cells;
                var cm = DetectColumnOrder(cells);
                for (int i = 5, j = 0, c = end.Row; i <= c; ++i, j = 0)
                {
                    string fullName = default!; bool gender = default;
                    DateOnly birthday = default; string citizenId = default!;
                    string address = default!; string phone = default!;
                    double salary = default;

                    if (!GetData(cells, i, cm, ref fullName, ref gender,
                        ref birthday, ref citizenId, ref address,
                        ref phone, ref salary)) continue;

                    if (!cleared)
                    {
                        data.Clear();
                        cleared = true;
                    }

                    if (IsDuplicated(citizenId)) continue;

                    data.Add(new Staff()
                    {
                        FullName = fullName,
                        Gender = gender,
                        Birthday = birthday,
                        CitizenId = citizenId,
                        Address = address,
                        Phone = phone,
                        Salary = salary
                    });
                }
            close:
                ep.Dispose();
                return true;
            }
            catch (Exception)
            {
                ep?.Dispose();
                return false;
            }
        }

        public void SaveChangeAndReload()
        {
            using (var dao = new StaffDAO())
            {
                foreach (var sa in dao.Set<Staff>())
                {
                    for (int c = data.Count; c > 0;)
                    {
                        if (data[--c] is Staff v)
                        {
                            if (sa.CitizenId == v.CitizenId)
                            {
                                sa.FullName = v.FullName;
                                sa.Gender = v.Gender;
                                sa.Birthday = v.Birthday;
                                sa.Address = v.Address;
                                sa.Phone = v.Phone;
                                sa.Salary = v.Salary;
                                dao.Update(sa);
                            }
                            else continue;
                        }
                        data.RemoveAt(c);
                    }
                }

                BigInteger id = dao.UsableId;
                for (int c = data.Count; c > 0;)
                {
                    if (data[--c] is Staff v)
                    {
                        dao.Add(new Staff(id + c)
                        {
                            FullName = v.FullName,
                            Gender = v.Gender,
                            Birthday = v.Birthday,
                            CitizenId = v.CitizenId,
                            Address = v.Address,
                            Phone = v.Phone,
                            Salary = v.Salary
                        });
                    }
                    data.RemoveAt(c);
                }
                dao.SaveChanges();
                LoadData(dao);
            }
        }

        private StaffImexBO()
        {
            data = new(typeof(IList<Staff>), null);
        }

        private void LoadData(StaffDAO dao)
        {
            foreach (var item in dao.Set<Staff>())
                data.Add(item);
        }

        public void LoadData()
        {
            data.Clear();
            using (var dao = new StaffDAO())
            {
                LoadData(dao);
            }
        }

        public static string? ConvertName(string name, bool toPropertyName = false)
        {
            if (toPropertyName)
            {
                if ("Họ và tên".Equals(name)) return nameof(Staff.FullName);
                else if ("Địa chỉ".Equals(name)) return nameof(Staff.Address);
                else if ("CCCD/CMND".Equals(name)) return nameof(Staff.CitizenId);
                else if ("Ngày sinh".Equals(name)) return nameof(Staff.Birthday);
                else if ("Số điện thoại".Equals(name)) return nameof(Staff.Phone);
                else if ("Giới tính".Equals(name)) return nameof(Staff.GenderString);
                else if ("Lương".Equals(name)) return nameof(Staff.Salary);
                else return null;
            }
            else
            {
                if (nameof(Staff.FullName).Equals(name)) return "Họ và tên";
                else if (nameof(Staff.Address).Equals(name)) return "Địa chỉ";
                else if (nameof(Staff.CitizenId).Equals(name)) return "CCCD/CMND";
                else if (nameof(Staff.Birthday).Equals(name)) return "Ngày sinh";
                else if (nameof(Staff.Phone).Equals(name)) return "Số điện thoại";
                else if (nameof(Staff.GenderString).Equals(name)) return "Giới tính";
                else if (nameof(Staff.Salary).Equals(name)) return "Lương";
                else return null;
            }
        }
    }
}
