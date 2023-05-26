using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    public class NormalStudent : Student
    {
        public int EnglishScore { get; set; }
        public int EntryTestScore { get; set; }
        public NormalStudent(string fullName, string doB, string sex, string phoneNumber, string universityName, int graduationLevel, int englishScore, int entryTestScore) : base(fullName, doB, sex, phoneNumber, universityName, graduationLevel)
        {
            EnglishScore = englishScore;
            EntryTestScore = entryTestScore;
        }
        public override string ShowMyInfo()
        {
            return base.ShowMyInfo() + "\n" + "English Score: " + this.EnglishScore + "\n" + "Entry Test Score: " + this.EntryTestScore;
        }
    }
}
