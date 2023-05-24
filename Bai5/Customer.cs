using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    public class Customer
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string IdentityNumber { get; set; }
        public Room Room { get; set; }
        public int RentDays { get; set; }

        public Customer(string fullName, int age, string identityNumber, Room room, int rentDays)
        {
            FullName = fullName;
            Age = age;
            IdentityNumber = identityNumber;
            Room = room;
            RentDays = rentDays;
        }
    }
}
