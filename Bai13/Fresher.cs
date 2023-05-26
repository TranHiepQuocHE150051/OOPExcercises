using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    public class Fresher : Employee
    {
        public DateTime GraduationDate { get; set; }
        public string GraduationRank { get; set; }
        public string Education { get; set; }
        public Fresher(int id, string fullName, DateTime birthDay, string phone, string email, int employee_type, int employee_count, List<Certificate> certificates, DateTime graduationDate, string graduationRank, string education) : base(id, fullName, birthDay, phone, email, employee_type, employee_count, certificates)
        {
            GraduationDate = graduationDate;
            GraduationRank = graduationRank;
            Education = education;
        }
        public override string ShowInfo()
        {
            return base.ShowInfo() + "\n" + "Type: Fresher" + "\n" + "Graduation Date: " + this.GraduationDate + "\n" + "Graduation Rank: " + this.GraduationRank + "\n" + "University Name: " + this.Education;
        }
    }
}
