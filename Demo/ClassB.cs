using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class ClassB : ClassA
    {
        public ClassB(int a, int b) : base(a, b)
        {
            Console.WriteLine("ClassB");
        }
    }
}
