using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class Motorbike : Vehicle
    {
        public int EngineCapacity { get; set; }
        public Motorbike(int id, string manufacturer, int manufacturedYear, decimal price, string color, int engineCapacity) : base(id, manufacturer, manufacturedYear, price, color)
        {
            EngineCapacity = engineCapacity;
        }
        public override string VehicleInfo()
        {
            return "Type: Motorbike" + "\n" + "Engine capacity: " + this.EngineCapacity+"cc"+"\n"+base.VehicleInfo();
        }
    }
}
