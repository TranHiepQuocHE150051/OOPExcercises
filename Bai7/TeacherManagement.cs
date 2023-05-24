using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    public class TeacherManagement
    {
        private List<Teacher> teachers;

        public TeacherManagement()
        {
            this.teachers = new List<Teacher>();
        }
        public void AddNewTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }
        public void RemoveTeacher(string teacherCode)
        {
            var teacher = this.teachers.Where(t => t.TeacherCode.Equals(teacherCode)).FirstOrDefault();
            if(teacher != null)
            {
                this.teachers.Remove(teacher);
                Console.WriteLine("Remove success");
            }
            else
            {
                Console.WriteLine("Remove failed. Teacher code is not existed");
            }
        }
        public decimal CalculateSalary(string teacherCode)
        {
            decimal salary = 0;
            var teacher = this.teachers.Where(t => t.TeacherCode.Equals(teacherCode)).FirstOrDefault();
            if(teacher != null)
            {
                salary = teacher.BasicSalary + teacher.SalaryBonus - teacher.PenaltyPay;
                
            }
            return salary;
        }
    }
}
