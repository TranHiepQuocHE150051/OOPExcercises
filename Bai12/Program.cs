using System;

namespace Bai12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleManagement vehicleManagement = new VehicleManagement();
            Vehicle car1 = new Car(1, "Ford", 2022, 150000, "red", 4, "strong");
            Vehicle car2 = new Car(2, "Ferrari", 2022, 200000, "black", 2, "excellent");
            Vehicle motorbike1 = new Motorbike(3, "Honda", 2023, 2000, "white", 150);
            Vehicle motorbike2 = new Motorbike(4, "Yamaha", 2023, 2500, "black", 150);
            Vehicle truck1 = new Truck(5, "Kenworth", 2023, 25000, "black", 15);
            Vehicle truck2 = new Truck(6, "Kenworth", 2023, 25000, "blue", 15);
            vehicleManagement.AddVehicle(car1);
            vehicleManagement.AddVehicle(car2);
            vehicleManagement.AddVehicle(motorbike1);
            vehicleManagement.AddVehicle(motorbike2);
            vehicleManagement.AddVehicle(truck1);
            vehicleManagement.AddVehicle(truck2);

            while (true)
            {
                Console.WriteLine("1:Add new vehicle ");
                Console.WriteLine("2:Delete a vehicle ");
                Console.WriteLine("3:Find vehicle by manufacturer and color ");
                Console.WriteLine("4:Exit ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        {
                            Console.WriteLine("a: Add new car");
                            Console.WriteLine("b: Add new truck");
                            Console.WriteLine("c: Add new motorbike");
                            string opt = Console.ReadLine();
                            switch (opt)
                            {
                                case "a":
                                    {
                                        Console.WriteLine("Enter vehicle Id: ");
                                        int vehicleId=Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter manufacturer: ");
                                        string manufacturer = Console.ReadLine();
                                        Console.WriteLine("Enter manufactured year: ");
                                        int manufaturedYear = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter price: ");
                                        decimal price = Convert.ToDecimal(Console.ReadLine());
                                        Console.WriteLine("Enter color: ");
                                        string color=Console.ReadLine();
                                        Console.WriteLine("Enter number of seats: ");
                                        int seats=Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter engine type:");
                                        string type=Console.ReadLine();
                                        Vehicle car = new Car(vehicleId, manufacturer, manufaturedYear, price, color, seats, type);
                                        vehicleManagement.AddVehicle(car);
                                        break;
                                    }
                                case "b":
                                    {
                                        Console.WriteLine("Enter vehicle Id: ");
                                        int vehicleId = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter manufacturer: ");
                                        string manufacturer = Console.ReadLine();
                                        Console.WriteLine("Enter manufactured year: ");
                                        int manufaturedYear = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter price: ");
                                        decimal price = Convert.ToDecimal(Console.ReadLine());
                                        Console.WriteLine("Enter color: ");
                                        string color = Console.ReadLine();
                                        Console.WriteLine("Enter weight: ");
                                        int weight = Convert.ToInt32(Console.ReadLine());
                                        
                                        Vehicle truck = new Truck(vehicleId, manufacturer, manufaturedYear, price, color, weight);
                                        vehicleManagement.AddVehicle(truck);
                                        break;
                                    }
                                case "c":
                                    {
                                        Console.WriteLine("Enter vehicle Id: ");
                                        int vehicleId = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter manufacturer: ");
                                        string manufacturer = Console.ReadLine();
                                        Console.WriteLine("Enter manufactured year: ");
                                        int manufaturedYear = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter price: ");
                                        decimal price = Convert.ToDecimal(Console.ReadLine());
                                        Console.WriteLine("Enter color: ");
                                        string color = Console.ReadLine();
                                        Console.WriteLine("Enter engine capacity: ");
                                        int capacity = Convert.ToInt32(Console.ReadLine());
                                        
                                        Vehicle motorbike = new Motorbike(vehicleId, manufacturer, manufaturedYear, price, color, capacity);
                                        vehicleManagement.AddVehicle(motorbike);
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Please enter a , b ,c");
                                        continue;
                                    }

                            }
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Enter vehicle Id: ");
                            int vehicleId=Convert.ToInt32(Console.ReadLine());
                            vehicleManagement.DeleteVehicle(vehicleId);
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Enter manufacturer: ");
                            string manufacturer = Console.ReadLine();
                            Console.WriteLine("Enter color: ");
                            string color = Console.ReadLine();
                            var vehicles = vehicleManagement.GetVehiclesByManufacturerAndColor(manufacturer, color);
                            Console.WriteLine("Search result: ");
                            foreach(var vehicle in vehicles)
                            {
                                Console.WriteLine("----------");
                                Console.WriteLine(vehicle.VehicleInfo());
                            }
                            break;
                        }
                    case "4":
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("Please enter between 1 and 4");
                            continue;
                        }
                }
            }
        }
    }
}
