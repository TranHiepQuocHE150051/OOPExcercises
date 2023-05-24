using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    public class Teacher
    {

        public string Name { get; set; }
        public int Age { get; set; } 
        public string HomeTown { get; set; }

        public string TeacherCode { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal SalaryBonus { get; set; }
        public decimal PenaltyPay { get; set; }

        public Teacher(string name, int age, string homeTown, string teacherCode, decimal basicSalary, decimal salaryBonus, decimal penaltyPay)
        {
            Name = name;
            Age = age;
            HomeTown = homeTown;
            TeacherCode = teacherCode;
            BasicSalary = basicSalary;
            SalaryBonus = salaryBonus;
            PenaltyPay = penaltyPay;
        }
    }
}
