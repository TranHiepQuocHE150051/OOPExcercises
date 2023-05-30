using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    public class SoPhuc
        
    {
        public double PhanThuc { get; set; }
        public double PhanAo { get; set; }

        public SoPhuc()
        {
        }

        public SoPhuc(double phanThuc, double phanAo)
        {
            PhanThuc = phanThuc;
            PhanAo = phanAo;
        }
    }
}
