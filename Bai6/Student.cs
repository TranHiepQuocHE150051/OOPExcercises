using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    public class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        public Student(int grade, string name, int age, string homeTown)
        {
            Grade = grade;
            Name = name;
            Age = age;
            HomeTown = homeTown;
        }
        public override string ToString()
        {
            return "Student Info: " + "\n" + "Grade: " + this.Grade + "\n" + "Full name: " + this.Name + "\n" + "Age: " + this.Age + "\n" + "Home Town: " + this.HomeTown ;
        }
    }
}
