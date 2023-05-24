using Bai7;

TeacherManagement manager = new TeacherManagement();
Console.WriteLine("Student Management System");
while (true)
{
    Console.WriteLine("1: Add new teacher");
    Console.WriteLine("2: Remove teacher");
    Console.WriteLine("3: Calculate salary");
    Console.WriteLine("4: Exit");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            {
                
                Console.WriteLine("Enter full name: ");
                string name =Console.ReadLine();
                Console.WriteLine("Enter age: ");
                int age=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter hometown: ");
                string hometown=Console.ReadLine();
                Console.WriteLine("Enter teacher code: ");
                string code= Console.ReadLine();
                Console.WriteLine("Enter basic salary:");
                decimal basicSalary = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter bonus salary:");
                decimal bonusSalary = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter penalty:");
                decimal penalty = decimal.Parse(Console.ReadLine());
                Teacher teacher = new Teacher(name,age,hometown,code, basicSalary, bonusSalary, penalty);
                manager.AddNewTeacher(teacher);
                break;
            }
        case "2":
            {
                Console.Write("Enter teacher code: ");
                string code = Console.ReadLine();
                manager.RemoveTeacher(code);
                break;
            }
        case "3":
            {
                Console.Write("Enter teacher code: ");
                string code = Console.ReadLine();
                decimal salary= manager.CalculateSalary(code);
                if (salary > 0)
                {
                    Console.WriteLine("Salary is: " + salary);
                }
                else
                {
                    Console.WriteLine("Wrong teacher code");
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
