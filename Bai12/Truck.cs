using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class Truck : Vehicle
    {
        public int Weight { get; set; }
        public Truck(int id, string manufacturer, int manufacturedYear, decimal price, string color, int weight) : base(id, manufacturer, manufacturedYear, price, color)
        {
            Weight = weight;
        }
        public override string VehicleInfo()
        {
            return "Type: Truck" + "\n" + "Weight: " + this.Weight+"tons"+"\n"+base.VehicleInfo();
        }
    }
}
