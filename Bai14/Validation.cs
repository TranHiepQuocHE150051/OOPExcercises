using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bai14
{
    static class Validation
    {
        public static void ValidateDate(string date)
        {
            DateTime tempDate;
            if (!DateTime.TryParseExact(date,"dd/MM/yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out tempDate))
            {
                throw new InvalidDOBException(date);
            }
        }
        public static void ValidateName(string name)
        {
            if(name.Length<10|| name.Length > 50)
            {
                throw new InvalidFullNameException(name);
            }
        }
        public static void ValidatePhoneNumber(string phone)
        {
            Regex regex = new Regex("(84|0[3|5|7|8|9])+([0-9]{8})");
            if (!regex.IsMatch(phone))
            {
                throw new InvalidPhoneNumberException(phone);
            }
        }
    }
}
