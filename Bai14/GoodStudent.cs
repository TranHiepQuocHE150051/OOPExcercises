using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai14
{
    public class GoodStudent : Student
    {
        public double Gpa { get; set; }
        public string BestReward { get; set; }
        public GoodStudent(string fullName, string doB, string sex, string phoneNumber, string universityName, int graduationLevel,double gpa,string bestReward) : base(fullName, doB, sex, phoneNumber, universityName, graduationLevel)
        {
            Gpa = gpa;
            BestReward = bestReward;
        }

        

        public override string ShowMyInfo()
        {
            return base.ShowMyInfo() + "\n" + "GPA: " + this.Gpa+"\n"+"Best reward: "+this.BestReward;
        }
    }
}
