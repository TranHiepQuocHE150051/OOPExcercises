﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    public class RoomA : Room
    {
        public RoomA(string type, int price) : base(type, price)
        {
            this.Price = 500;
        }
    }
}
