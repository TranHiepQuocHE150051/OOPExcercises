using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public int ManufacturedYear { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }



        public Vehicle(int id, string manufacturer, int manufacturedYear, decimal price, string color)
        {
            Id = id;
            Manufacturer = manufacturer;
            ManufacturedYear = manufacturedYear;
            Price = price;
            Color = color;
        }
        public virtual string VehicleInfo()
        {
            return "Id: " + this.Id + "\n" + "Manufacturer: " + this.Manufacturer + "\n" + "Manufactured Year: " + this.ManufacturedYear + "\n" + "Price: " + this.Price+"$" + "\n" + "Color: " + this.Color;
        }
    }
}
