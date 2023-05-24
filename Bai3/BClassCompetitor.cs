using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class BClassCompetitor : Competitor
    {
        public static string MATH = "math";
        public static string BIOLOGY = "biology";
        public static string CHEMISTRY = "chemistry";
        public BClassCompetitor(string identificationNumber, string fullName, string address, int priorityLevel) : base(identificationNumber, fullName, address, priorityLevel)
        {
        }
        public override string ToString()
        {
            return "Class : B" + "\n" + "Identification Number: " + this.IdentificationNumber + "\n" + "Full Name: " + this.FullName + "\n" + "Address: " + this.Address + "\n" + "Priority Level: " + this.PriorityLevel + "\n" + "Subject: " + MATH + ", " + BIOLOGY + ", " + CHEMISTRY;
        }
    }
}
