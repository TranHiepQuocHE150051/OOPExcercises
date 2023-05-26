using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    public class OfficialStudent : Student
    {

        public OfficialStudent(int studentId, string name, DateTime dateOfBirth, int startYear, double entryPoint, List<StudyResult> studyResults) : base(studentId, name, dateOfBirth, startYear, entryPoint, studyResults)
        {
        }
        public override string Display()
        {
            return base.Display();
        }
    }
}
