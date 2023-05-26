using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
 
        
        public class FullNameException : Exception
        {

            public FullNameException(string name): base(String.Format("Invalid name: {0} ",name))
            {

            }
        }
        public class EmailException : Exception
        {

            public EmailException(string email) : base(String.Format("Invalid email: {0} ", email))
            {

            }
        }
        public class PhoneException : Exception
        {

            public PhoneException(string phone) : base(String.Format("Invalid phone: {0} ", phone))
            {
            }
        }
        public class BirthdayException : Exception
        {

            public BirthdayException(string date) : base(String.Format("Invalid Date: {0} ", date))
            {

            }
        }



}

