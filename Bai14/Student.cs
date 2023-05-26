using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    public class Student
    {
        public string FullName { get; set; }
        public string DoB { get; set; }
        public string sex { get; set; }
        public string PhoneNumber { get; set; }
        public string UniversityName { get; set; }
        public int graduationLevel { get; set; }

        public Student(string fullName, string doB, string sex, string phoneNumber, string universityName, int graduationLevel)
        {
            FullName = fullName;
            DoB = doB;
            this.sex = sex;
            PhoneNumber = phoneNumber;
            UniversityName = universityName;
            this.graduationLevel = graduationLevel;
        }
        public virtual string ShowMyInfo()
        {
            return "Student Info " + "\n" + "Full name: " + this.FullName + "\n" + "Date of birth: " + this.DoB + "\n" + "Sex: " + this.sex + "\n" + "Phone: " + this.PhoneNumber + "\n" + "University name: " + this.UniversityName + "\n" + "Graduation level: " + this.graduationLevel;

        }
    }
}
