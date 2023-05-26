using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    
    
        public class InvalidFullNameException : Exception
        {
            public InvalidFullNameException(string name) : base(String.Format("Invalid name: {0} ", name))
            {

            }
        }

        public class NotANumberException : Exception
        {
            public NotANumberException(string value) : base(String.Format("Invalid input , must be a number: {0} ", value))
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
            public InvalidInput() : base("Input files have unknow errors !!!")
            {

            }
        }
    }

