using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    public class InvalidFullNameException : Exception
    {
        public InvalidFullNameException(string name) : base(String.Format("Invalid name: {0} ", name))
        {

        }
    }

    public class InvalidPhoneNumberException : Exception
    {
        public InvalidPhoneNumberException(string phone) : base(String.Format("Invalid phone: {0} ", phone))
        {
        }
    }
    public class InvalidDOBException : Exception
    {
        public InvalidDOBException(string date) : base(String.Format("Invalid Date: {0} ", date))
        {

        }
    }
    public class InvalidInput : Exception
    {
        public InvalidInput() : base("Input files have unknown error")
        {

        }
    }
}
