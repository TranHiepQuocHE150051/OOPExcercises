using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bai13
{
    static class Utility
    {
        public static void ValidateEmail(string email)
        {

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!regex.IsMatch(email))
            {
                throw new EmailException(email);
            }
        }
        public static void ValidateFullName(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new FullNameException(name);
            }
        }
        public static void ValidatePhone(string phone)
        {
            Regex regex = new Regex("(84|0[3|5|7|8|9])+([0-9]{8})");
            if (!regex.IsMatch(phone))
            {
                throw new PhoneException(phone);
            }
        }
        public static void ValidateDate(string date)
        {
            DateTime tempDate;
            if(!DateTime.TryParse(date, out tempDate))
            {
                throw new BirthdayException(date);
            }
        }
    }
}
