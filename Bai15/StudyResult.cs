using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai15
{
    public class StudyResult
    {
        public string SemesterName { get; set; }
        public double AverageGrade { get; set; }

        public StudyResult(string semesterName, double averageGrade)
        {
            SemesterName = semesterName;
            AverageGrade = averageGrade;
        }
        public StudyResult()
        {
        }
    }
}
