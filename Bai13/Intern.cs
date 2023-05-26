using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    public class Intern : Employee
    {
        public string Majors { get; set; }
        public int Semester { get; set; }
        public string UniversityName { get; set; }
        public Intern(int id, string fullName, DateTime birthDay, string phone, string email, int employee_type, int employee_count, List<Certificate> certificates, string majors, int semester, string universityName) : base(id, fullName, birthDay, phone, email, employee_type, employee_count, certificates)
        {
            Majors = majors;
            Semester = semester;
            UniversityName = universityName;
        }
        public override string ShowInfo()
        {
            return base.ShowInfo()+"\n"+"Type: Intern"+"\n"+"Majors: "+this.Majors + "\n" + "Semester: " + this.Semester + "\n" + "University Name: " + this.UniversityName;
        }
    }
}
