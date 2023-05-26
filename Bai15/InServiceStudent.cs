using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    public class InServiceStudent : Student
    {
        public string EducationPlace { get; set; }
        public InServiceStudent(int studentId, string name, DateTime dateOfBirth, int startYear, double entryPoint, List<StudyResult> studyResults, string educationPlace) : base(studentId, name, dateOfBirth, startYear, entryPoint, studyResults)
        {
            EducationPlace = educationPlace;
        }
        public override string Display()
        {
            return base.Display()+"\n"+"Education Place: "+this.EducationPlace;
        }
    }
}
