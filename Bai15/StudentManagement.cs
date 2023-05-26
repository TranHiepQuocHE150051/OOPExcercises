using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    public class StudentManagement
    {
        private List<Student> students;
        private List<Department> departments;
            
        public StudentManagement()
        {
            
            this.students = new List<Student>();
            this.departments = new List<Department>();
            
        }
        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }
        public void AddDepartment(Department department)
        {
            this.departments.Add(department);
        }
        public bool IsOfficialStudent(Student student)
        {
            return (student.GetType()== typeof(OfficialStudent));
        }
        public int CountNumberOfOfficialStudentInDepartment(Department department)
        {
            int count = 0;
            foreach(var student in department.Students)
            {
                if(student.GetType()== typeof(OfficialStudent))
                {
                    count++;
                }
            }
            return count;
        }
        public Student GetHighestGradeStudentInDepartment(Department department)
        {
            return department.Students.OrderByDescending(s=>s.EntryPoint).First();
        }
        public List<InServiceStudent> GetInServiceStudentByDepartmentAndPlace(Department department,string place)
        {
            List<InServiceStudent> InServiceStudents = new List<InServiceStudent>();
            foreach(var student in department.Students)
            {
                if (student.GetType() == typeof(InServiceStudent))
                {
                    InServiceStudents.Add((InServiceStudent)student);
                }
            }
            return InServiceStudents.Where(s => s.EducationPlace.Equals(place)).ToList();
        }
        public List<Student> GetStudentsHaveGradeHigherThan8AtNearestSemester()
        {
            List<Student> students = new List<Student>();
            foreach(Department department in this.departments)
            {
                foreach(var student in department.Students)
                {
                    if (student.studyResults.Last().AverageGrade >= 8.0)
                    {
                        students.Add(student);
                    }
                }
            }
            return students;
        }
        //public List<Student> GetHighestGradeStudentInEachDepartment()
        //{
        //    List<Student> students = new List<Student>();
        //    foreach(var department in this.departments)
        //    {
                
        //        foreach(var student in department.Students)
        //        {

        //        }
        //    }
        //}


    }
}
