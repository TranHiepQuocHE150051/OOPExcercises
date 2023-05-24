using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    public class CClassCompetitor : Competitor
    {
        public static string LITERATURE = "literature";
        public static string HISTORY = "history";
        public static string GEOGRAPHY = "geography";
        public CClassCompetitor(string identificationNumber, string fullName, string address, int priorityLevel) : base(identificationNumber, fullName, address, priorityLevel)
        {
        }
        public override string ToString()
        {
            return "Class : B" + "\n" + "Identification Number: " + this.IdentificationNumber + "\n" + "Full Name: " + this.FullName + "\n" + "Address: " + this.Address + "\n" + "Priority Level: " + this.PriorityLevel + "\n" + "Subject: " + LITERATURE + ", " + HISTORY + ", " + GEOGRAPHY;
        }
    }
}
