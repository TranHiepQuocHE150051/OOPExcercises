using Bai3;
using System.Transactions;

CompetitorManager manager = new CompetitorManager();
while (true)
{
    Console.WriteLine("Competitor Management System");
    Console.WriteLine("1: Add new competitor");
    Console.WriteLine("2: All competitors infomation");
    Console.WriteLine("3: Find competitor by identification number");
    Console.WriteLine("4: Exit");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            {
                Console.WriteLine("Select your class: A,B,C ");
                Console.WriteLine("A: Math, Physics, Chemistry");
                Console.WriteLine("B: Math, Chemistry, Biology");
                Console.WriteLine("C: Literature, History, Geoology");
                string type = Console.ReadLine();
                switch (type)
                {
                    case "A":
                        {
                            Console.WriteLine("Enter identification number: ");
                            string inum = Console.ReadLine();
                            Console.WriteLine("Enter full name: ");
                            string name= Console.ReadLine();
                            Console.WriteLine("Enter address: ");
                            string address = Console.ReadLine();
                            Console.WriteLine("Priority Level: ");
                            int prioritylevel = Convert.ToInt32(Console.ReadLine());
                            Competitor competitor = new AClassCompetitor(inum,name,address,prioritylevel);
                            manager.AddNewCompetitor(competitor);
                            break;
                        }
                    case "B":
                        {
                            Console.WriteLine("Enter identification number: ");
                            string inum = Console.ReadLine();
                            Console.WriteLine("Enter full name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter address: ");
                            string address = Console.ReadLine();
                            Console.WriteLine("Priority Level: ");
                            int prioritylevel = Convert.ToInt32(Console.ReadLine());
                            Competitor competitor = new BClassCompetitor(inum, name, address, prioritylevel);
                            manager.AddNewCompetitor(competitor);
                            break;
                        }
                    case "C":
                        {
                            Console.WriteLine("Enter identification number: ");
                            string inum = Console.ReadLine();
                            Console.WriteLine("Enter full name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter address: ");
                            string address = Console.ReadLine();
                            Console.WriteLine("Priority Level: ");
                            int prioritylevel = Convert.ToInt32(Console.ReadLine());
                            Competitor competitor = new CClassCompetitor(inum, name, address, prioritylevel);
                            manager.AddNewCompetitor(competitor);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong input");
                            break;
                        }
                }
                break;
            }
        case "2":
            {
                Console.WriteLine("=====Competitors Information====");
                List<Competitor> competitors = manager.GetCompetitors();
                foreach(var competitor in competitors)
                {
                    Console.WriteLine("---------------");
                    Console.WriteLine(competitor.ToString());
                }
                break;
            }
        case "3":
            {
                Console.WriteLine("Enter identification number to search: ");
                string inum = Console.ReadLine();
                Competitor competitor = manager.FindByIdentificationNumber(inum);
                if(competitor != null)
                {
                    Console.WriteLine(competitor.ToString());
                }
                else
                {
                    Console.WriteLine("Wrong identification number");
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
