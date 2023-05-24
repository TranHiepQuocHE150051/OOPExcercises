using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Newspaper : Document
    {
        public string ReleasedDate { get; set; }
        public Newspaper(int id, string publisher, int releasedNum, string releasedDate) : base(id, publisher, releasedNum)
        {
            ReleasedDate = releasedDate;
        }
        public override string ToString()
        {
            return "Type : Newspaper" + "\n" + "Id: " + this.Id + "\n" + "Publisher name: " + this.Publisher + "\n" + "Released Number: " + this.ReleasedNum + "\n" + "Released Date: " + this.ReleasedDate;

        }
    }
}
