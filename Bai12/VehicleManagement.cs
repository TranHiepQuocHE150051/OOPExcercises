using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai12
{
    internal class VehicleManagement
    {
        private List<Vehicle> _vehicles;

        public VehicleManagement()
        {
            this._vehicles = new List<Vehicle>();
        }
        public List<Vehicle> Vehicles()
        {
            return this._vehicles;
        }
        public void AddVehicle(Vehicle vehicle)
        {
            this._vehicles.Add(vehicle);
        }
        public void DeleteVehicle(int vehicleId)
        {
            var vehicle = this._vehicles.Where(v => v.Id == vehicleId).SingleOrDefault();
            if (vehicle != null)
            {
                this._vehicles.Remove(vehicle);
                Console.WriteLine("Remove success");
            }
            else
            {
                Console.WriteLine("Vehicle not existed");
            }
        }
        public List<Vehicle> GetVehiclesByManufacturerAndColor(string manufacturer, string color)
        {
            var vehicles = this._vehicles.Where(v => v.Manufacturer.ToLower().Equals(manufacturer.ToLower())
                                                    && v.Color.ToLower().Equals(v.Color.ToLower())).ToList();
            return vehicles;
        }
    }
}
