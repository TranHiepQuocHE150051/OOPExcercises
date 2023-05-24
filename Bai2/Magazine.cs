using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Magazine : Document
    {
        public int ReleasedNo { get; set; }
        public int ReleasedMonth { get; set; }
        public Magazine(int id, string publisher, int releasedNum, int releasedNo, int releasedMonth) : base(id, publisher, releasedNum)
        {
            ReleasedNo = releasedNo;
            ReleasedMonth = releasedMonth;
        }
        public override string ToString()
        {
            return "Type : Magazine" + "\n" + "Id: " + this.Id + "\n" + "Publisher name: " + this.Publisher + "\n" + "Released Number: " + this.ReleasedNum + "\n" + "Released No: " + this.ReleasedNo + "\n" + "Released Month: " + this.ReleasedMonth;

        }
    }
}
