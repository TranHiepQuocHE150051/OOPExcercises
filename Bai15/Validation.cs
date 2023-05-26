using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bai15
{
    static class Validation
    {
        public static void ValidateDate(string date)
        {
            DateTime tempDate;
            if (!DateTime.TryParseExact(date, "dd/MM/yyyy",
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out tempDate))
            {
                throw new InvalidDOBException(date);
            }
        }
        public static void ValidateName(string name)
        {
            if (name.Length < 10 || name.Length > 50)
            {
                throw new InvalidFullNameException(name);
            }
        }
        public static void ValidateNumber(string number)
        {
            Regex regex = new Regex("\"^-?\\\\d*(\\\\.\\\\d+)?$\"\r\n");
            if (!regex.IsMatch(number))
            {
                throw new NotANumberException(number);
            }
        }
    }
}
