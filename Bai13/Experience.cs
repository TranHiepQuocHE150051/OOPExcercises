using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    public class Experience : Employee
    {
        public int ExpInYear { get; set; }
        public string ProSkill { get; set; }
        public Experience(int id, string fullName, DateTime birthDay, string phone, string email, int employee_type, int employee_count, List<Certificate> certificates, int expInYear, string proSkill) : base(id, fullName, birthDay, phone, email, employee_type, employee_count, certificates)
        {
            ExpInYear = expInYear;
            ProSkill = proSkill;
        }
        public override string ShowInfo()
        {
            return base.ShowInfo() + "\n" + "Type: Experience" + "\n" + "Year of experience: " + this.ExpInYear + "\n" + "Pro skill: " + this.ProSkill;
        }
    }
}
