using System;
using System.Collections.Generic;

namespace Bai15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Management");
            StudentManagement studentManagement = new StudentManagement();
            Department d1 = new Department("Software Engineering", new List<Student>());
            Department d2 = new Department("Digital Marketing", new List<Student>());
            Department d3 = new Department("Graphics Design", new List<Student>());
            studentManagement.AddDepartment(d1);
            studentManagement.AddDepartment(d2);
            studentManagement.AddDepartment(d3);

            Student s1 = new Student(1, "Tran Hiep Quoc", DateTime.Parse("19/10/2001"), 2019, 9, new List<StudyResult>());
            Student s2 = new Student(1, "Le Trung Thanh", DateTime.Parse("26/11/2001"), 2019, 8, new List<StudyResult>());
            Student s3 = new Student(1, "Pham Minh Giang", DateTime.Parse("17/01/2001"), 2019, 8.5, new List<StudyResult>());
            Student s4 = new Student(1, "Nguyen Duc Thinh", DateTime.Parse("09/07/2001"), 2019, 9, new List<StudyResult>());
            Student s5 = new Student(1, "Nguyen Thuy Linh", DateTime.Parse("12/08/2001"), 2019, 7.5, new List<StudyResult>());
            Student s6 = new Student(1, "Duong Thuy Nhung", DateTime.Parse("19/10/2001"), 2019, 8.5, new List<StudyResult>());
            Student s7 = new Student(1, "Do Thanh Trung", DateTime.Parse("02/10/2001"), 2019, 7, new List<StudyResult>());
            Student s8 = new Student(1, "Nguyen Gia Phu", DateTime.Parse("02/09/2001"), 2019, 7.5, new List<StudyResult>());
            Student s9 = new Student(1, "Hoang Minh Viet", DateTime.Parse("12/02/2001"), 2019, 9, new List<StudyResult>());
            studentManagement.AddStudent(s1);
            studentManagement.AddStudent(s2);
            studentManagement.AddStudent(s3);
            studentManagement.AddStudent(s4);
            studentManagement.AddStudent(s5);
            studentManagement.AddStudent(s6);
            studentManagement.AddStudent(s7);
            studentManagement.AddStudent(s8);
            studentManagement.AddStudent(s9);
            d1.Students.Add(s1);
            d1.Students.Add(s2);
            d1.Students.Add(s3);
            d2.Students.Add(s4);
            d2.Students.Add(s5);
            d2.Students.Add(s6);
            d3.Students.Add(s7);
            d3.Students.Add(s8);
            d3.Students.Add(s9);
            StudyResult result1 = new StudyResult("Ki 1",9);
            StudyResult result2 = new StudyResult("Ki 1",8.5);
            StudyResult result3 = new StudyResult("Ki 1",8);
            StudyResult result4 = new StudyResult("Ki 1",9.5);
            StudyResult result5 = new StudyResult("Ki 1",10);
            StudyResult result6 = new StudyResult("Ki 1",7.5);
            StudyResult result7 = new StudyResult("Ki 1",7);
            StudyResult result8 = new StudyResult("Ki 2", 9);
            StudyResult result9 = new StudyResult("Ki 2", 8.5);
            StudyResult result10 = new StudyResult("Ki 2", 8);
            StudyResult result11 = new StudyResult("Ki 2", 9.5);
            StudyResult result12 = new StudyResult("Ki 2", 10);
            StudyResult result13 = new StudyResult("Ki 2", 7.5);
            StudyResult result14 = new StudyResult("Ki 2", 7);
            StudyResult result15 = new StudyResult("Ki 3", 9);
            StudyResult result16 = new StudyResult("Ki 3", 8.5);
            StudyResult result17 = new StudyResult("Ki 3", 8);
            StudyResult result18 = new StudyResult("Ki 3", 9.5);
            StudyResult result19 = new StudyResult("Ki 3", 10);
            StudyResult result20 = new StudyResult("Ki 3", 7.5);
            StudyResult result21 = new StudyResult("Ki 3", 7);

            s1.studyResults.Add(result1);
            s1.studyResults.Add(result9);
            s1.studyResults.Add(result16);
            s2.studyResults.Add(result2);
            s2.studyResults.Add(result9);
            s2.studyResults.Add(result21);
            s3.studyResults.Add(result6);
            s3.studyResults.Add(result14);
            s3.studyResults.Add(result20);
            s4.studyResults.Add(result7);
            s4.studyResults.Add(result13);
            s4.studyResults.Add(result21);
            s5.studyResults.Add(result1);
            s5.studyResults.Add(result8);
            s5.studyResults.Add(result15);
            s6.studyResults.Add(result21);
            s6.studyResults.Add(result13);
            s6.studyResults.Add(result5);
            s7.studyResults.Add(result4);
            s7.studyResults.Add(result11);
            s7.studyResults.Add(result18);
            s8.studyResults.Add(result2);
            s8.studyResults.Add(result10);
            s8.studyResults.Add(result19);
            s9.studyResults.Add(result1);
            s9.studyResults.Add(result8);
            s9.studyResults.Add(result15);


            Console.WriteLine("Student Management System");
            while (true)
            {
                Console.WriteLine("1:Enter new student ");
                Console.WriteLine("2:Enter new student ");
                Console.WriteLine("3:Enter new student ");
            }









        }
    }
}
