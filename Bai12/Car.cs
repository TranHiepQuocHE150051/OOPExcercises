using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    public class Car : Vehicle
    {
        public int Seats { get; set; }
        public string EngineType { get; set; }
        public Car(int id, string manufacturer, int manufacturedYear, decimal price, string color, int seats, string engineType) : base(id, manufacturer, manufacturedYear, price, color)
        {
            Seats = seats;
            EngineType = engineType;
        }
        public override string VehicleInfo()
        {
            return "Type: Car"+"\n"+"Seats: "+this.Seats+"\n"+"EngineType: "+this.EngineType+"\n"+base.VehicleInfo();
        }
    }
}
