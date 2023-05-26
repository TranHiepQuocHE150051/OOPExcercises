using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Bai15
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int StartYear { get; set; }
        public double EntryPoint { get; set; }
        public List<StudyResult> studyResults { get; set; }

        public Student(int studentId, string name, DateTime dateOfBirth, int startYear, double entryPoint, List<StudyResult> studyResults)
        {
            StudentId = studentId;
            Name = name;
            DateOfBirth = dateOfBirth;
            StartYear = startYear;
            EntryPoint = entryPoint;
            this.studyResults = studyResults;
        }
        public virtual string Display()
        {
            return "Student Info " + "\n" + "ID: " + this.StudentId + "\n" + "Full name: " + this.Name + "\n" + "Date of birth: " + this.DateOfBirth + "\n" + "Start Year: " + this.StartYear + "\n" + "Entry point: " + this.EntryPoint;

        }
    }
}
