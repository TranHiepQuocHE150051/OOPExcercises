
using Bai9;

Console.WriteLine("Electricity Receipt Management");
ReceiptManagement management = new ReceiptManagement();
while (true)
{
    Console.WriteLine("1:Add new customer");
    Console.WriteLine("2:Update  customer");
    Console.WriteLine("3:Delte customer");
    Console.WriteLine("4:Calculate money for customer");
    Console.WriteLine("5:List customer");
    Console.WriteLine("6:Exit");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            {
                try
                {
                    Console.WriteLine("Enter owner name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter address number: ");
                    int addressNumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter electric meter code: ");
                    int electricCode = Convert.ToInt32(Console.ReadLine());
                    FamilyInfo customer = new FamilyInfo(name, addressNumber, electricCode);
                    management.AddCustomer(customer);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                break;
            }
        case "2":
            {
                Console.WriteLine("Enter electric meter code: ");
                int electricCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter new owner name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter new address number: ");
                int addressNumber = Convert.ToInt32(Console.ReadLine());
                management.UpdateCustomer(electricCode,name,addressNumber);
                break;
            }
        case "3":
            {
                Console.WriteLine("Enter electric meter code: ");
                int electricCode = Convert.ToInt32(Console.ReadLine());
                management.DeleteCustomer(electricCode);
                break;
            }
        case "4":
            {
                Console.WriteLine("Enter electric meter code: ");
                int electricCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter old electric number: ");
                int oldNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter new electric number: ");
                int newNumber = Convert.ToInt32(Console.ReadLine());
                decimal result = management.CalculateMoney(electricCode, oldNumber, newNumber);
                if (result > 0)
                {
                    Console.WriteLine("Paid amount is: "+result);
                }
                
                break;
            }
        case "5":
            {
                foreach(var customer in management.CustomerList())
                {
                    Console.WriteLine("------------");
                    Console.WriteLine(customer.ToString());
                }
                break;
            }
        case "6":
            {
                return;
            }
        default:
            {
                Console.WriteLine("Please enter between 1 and 5");
                continue;
            }
    }
}