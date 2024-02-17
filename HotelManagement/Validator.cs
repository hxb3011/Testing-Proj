using iTextSharp.text.xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HotelManagement
{
    public class Validator
    {
        private static Validator instance;

        public static Validator Instance
        {
            get
            {
                if (instance == null)
                    instance = new Validator();
                return instance;
            }
            private set { instance = value;  }
        }
        private bool matchRegex(string text,Regex reg)
        {
            if (!reg.IsMatch(text))
            {
                return false;
            }
            return true;
        }
        public bool checkTextBox(TextBox txb,Label errMsglbl, string[] rules)
        {
            
            foreach(var rule in rules) 
            {
                switch (rule)
                {
                    case "not-empty":
                        if(string.IsNullOrEmpty(txb.Text.Trim()))
                        {
                            errMsglbl.Text = "Trường này không được để trống";
                            return false;
                        }
                        else
                        {
                            errMsglbl.Text = "";
                        }
                        break;
                    case "positive-number":
                        if (matchRegex(txb.Text.Trim(),new Regex("^\\d+$")))
                        {
                            errMsglbl.Text = "";
                        }
                        else
                        {
                            errMsglbl.Text = "Trường này phải là một con số dương";
                            return false;
                        }
                        break;
                    case "room-price":
                        if (!Double.TryParse(txb.Text.Trim(),out double price) || (price <= 0 || price > 10000000))
                        {
                            Console.WriteLine(price);
                            errMsglbl.Text = "Giá loại phòng phải lớn hơn 0 và nhỏ hơn 10 triệu đồng";
                            return false;
                        }
                        else
                        {
                            errMsglbl.Text = "";
                        }
                        break;
                    case "name":
                        if (!matchRegex(txb.Text, new Regex("^[^\\d!@#\\$%^&*()_+={}\\[\\]:;<>,.?/~\\\\-]*$")))
                        {
                            errMsglbl.Text = "Tên không được chứa số/kí tự đặc biệt";
                            return false;
                        }
                        else
                        {
                            errMsglbl.Text = "";
                        }
                        break;
                    case "citizen-id":
                        string name = txb.Text.Trim();
                        if ((name == null) || !(name.Length is 9 or 12) || !(ulong.TryParse(name, out _)))
                        {
                            errMsglbl.Text = "CCCD/CMND không hợp lệ";
                            return false;
                        }
                        else
                        {
                            errMsglbl.Text = "";
                        }
                        break;
                    case "phone-number":
                        if (!matchRegex(txb.Text.Trim(),new Regex(@"^(03|05|07|08|09|01[2|6|8|9])+([0-9]{8})$")))
                        {
                            errMsglbl.Text = "SĐT không hợp lệ";
                            return false;
                        }
                        else
                        {
                            errMsglbl.Text = "";
                        }
                        break;
                    default:
                        return false;
                }
            }
            return true;
        }
    }
}
