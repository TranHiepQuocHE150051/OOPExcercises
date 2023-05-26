using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class ClassA
    {
        public int a { get; set; }
        public int b { get; set; }


        public ClassA(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine("ClassA");
        }
    }
}
