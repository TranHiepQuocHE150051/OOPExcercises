using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    public class RoomB : Room
    {
        public RoomB(string type, int price) : base(type, price)
        {
            this.Price = 300;
        }
    }
}
