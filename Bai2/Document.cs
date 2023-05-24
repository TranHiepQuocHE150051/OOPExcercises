using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class Document
    {
        public int Id { get; set; }
        public string Publisher { get; set; }
        public int ReleasedNum { get; set; }

        public Document(int id, string publisher, int releasedNum)
        {
            Id = id;
            Publisher = publisher;
            ReleasedNum = releasedNum;
        }
    }
}
