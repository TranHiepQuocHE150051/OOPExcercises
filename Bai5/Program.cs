using Bai5;

HotelManagement manager = new HotelManagement();
Console.WriteLine("Hotel Management System");
while (true)
{
    Console.WriteLine("1: Add new customer");
    Console.WriteLine("2: Remove a customer");
    Console.WriteLine("3: Calculate money for customer");
    Console.WriteLine("4: Exit");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            {
                Console.WriteLine("Enter full name: ");
                string name= Console.ReadLine();
                Console.WriteLine("Enter age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter identity number: ");
                string inum= Console.ReadLine();
                Console.WriteLine("Enter number of days to rent: ");
                int rentdays= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter type of room");
                Console.WriteLine("A: 500$ ");
                Console.WriteLine("B: 300$ ");
                Console.WriteLine("C: 100$ ");
                string type = Console.ReadLine();
                if(type.Equals("A"))
                {
                    Room room = new RoomA("A",500);
                    Customer customer = new Customer(name,age,inum,room,rentdays);
                    manager.AddNewCustomer(customer);
                }
                if (type.Equals("B"))
                {
                    Room room = new RoomA("B", 300);
                    Customer customer = new Customer(name, age, inum, room, rentdays);
                    manager.AddNewCustomer(customer);
                }
                if (type.Equals("C"))
                {
                    Room room = new RoomA("C", 100);
                    Customer customer = new Customer(name, age, inum, room, rentdays);
                    manager.AddNewCustomer(customer);
                }
                break;
            }
        case "2":
            {
                Console.WriteLine("Enter identity number: ");
                string inum= Console.ReadLine();
                manager.RemoveCustomer(inum);
                break;
            }
        case "3":
            {
                Console.WriteLine("Enter identity number: ");
                string inum = Console.ReadLine();
               
                int result=manager.CalculateMoney(inum);
                if (result == 0)
                {
                    Console.WriteLine("Customer not existed");
                }
                else
                {
                    Console.WriteLine("Customer need to pay: " + result);
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
