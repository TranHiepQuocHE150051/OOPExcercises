using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class Competitor
    {
        public string IdentificationNumber { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int PriorityLevel { get; set; }

        public Competitor(string identificationNumber, string fullName, string address, int priorityLevel)
        {
            IdentificationNumber = identificationNumber;
            FullName = fullName;
            Address = address;
            PriorityLevel = priorityLevel;
        }
    }
}
