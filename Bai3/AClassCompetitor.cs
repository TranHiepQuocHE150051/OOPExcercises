using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class AClassCompetitor : Competitor
    {
        public static string MATH = "math";
        public static string PHYSICS = "physics";
        public static string CHEMISTRY = "chemistry";
        public AClassCompetitor(string identificationNumber, string fullName, string address, int priorityLevel) : base(identificationNumber, fullName, address, priorityLevel)
        {
        }
        public override string ToString()
        {
            return "Class : A" + "\n" + "Identification Number: " + this.IdentificationNumber + "\n" + "Full Name: " + this.FullName + "\n" + "Address: " + this.Address + "\n" + "Priority Level: " + this.PriorityLevel + "\n" + "Subject: " + MATH+", "+PHYSICS+", "+CHEMISTRY;
        }
    }
}
