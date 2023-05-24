using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    public class SchoolManagement
    {
        private List<Student> students;

        public SchoolManagement()
        {
            this.students = new List<Student>();
        }
        public void AddNewStudent(Student student)
        {
            this.students.Add(student);
        }
        public List<Student> GetAllStudents()
        {
            return this.students;
        }
        public List<Student> GetStudentsByAge(int age)
        {
            return this.students.Where(s => s.Age == age).ToList();
        }
        public int GetNumberOfStudents(int age, string hometown)
        {
            return this.students.Where(s=>s.Age== age && s.HomeTown.Equals(hometown)).Count();
        }
    }
}
