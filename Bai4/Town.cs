using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    public class Town
    {
        public List<Family> Families { get; set; }

        public Town(List<Family> families)
        {
            Families = families;
        }
    }
}
