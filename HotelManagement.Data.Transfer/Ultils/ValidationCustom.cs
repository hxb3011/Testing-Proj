using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HotelManagement.Ultils
{
    public class ValidationCustom
    {
        public static Boolean checkDouble(string temp)
        {
            if(Double.TryParse(temp, out var result))
            {
                return result >= 0;
            }
            return false;
        }

        public static Boolean checkPhoneNumber(string temp)
        {
            var pattern = @"^(03|05|07|08|09|01[2|6|8|9])+([0-9]{8})$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(temp);
        }

        public static Boolean checkCitizenId(string citizenId)
        {
            return double.TryParse(citizenId, out var result);
        }
    }

}
