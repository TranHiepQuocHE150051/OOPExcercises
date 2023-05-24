using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    public class Room
    {
        public string Type { get; set; }
        public int Price { get; set; }

        public Room(string type, int price)
        {
            Type = type;
            Price = price;
        }
    }
}
