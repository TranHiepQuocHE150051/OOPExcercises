using Bai13;

EmployeeManagement manager = new EmployeeManagement();
Console.WriteLine("Employee management app");
while (true)
{
    Console.WriteLine("1: Add new employee");
    Console.WriteLine("2: Update an employee");
    Console.WriteLine("3: Remove an employee");
    Console.WriteLine("4: Find employee by type");
    Console.WriteLine("5: Exit");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            {
                Console.WriteLine("a: Add new experience");
                Console.WriteLine("b: Add new fresher");
                Console.WriteLine("c: Add new intern");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "a":
                        {

                                string fullname;
                                string birthday;
                                string phone;
                                string email;
                                Console.WriteLine("Enter ID: ");
                                int id = Convert.ToInt32(Console.ReadLine());
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("Enter full name: ");
                                         fullname = Console.ReadLine();
                                        Utility.ValidateFullName(fullname);
                                        break;
                                    } catch (FullNameException ex)
                                    {
                                        Console.WriteLine("Wrong format for full name!");
                                        continue;
                                    } 
                                
                                }  
                                while (true)
                                {
                                    try
                                    {
                                    Console.WriteLine("Enter birth day: ");
                                    birthday = Console.ReadLine();
                                    Utility.ValidateDate(birthday);
                                    break;
                                    } catch (BirthdayException ex)
                                    {
                                        Console.WriteLine("Wrong format for birthday (dd/MM/yyyy)!");
                                        continue;
                                    }                                
                                }
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("Enter phone: ");
                                        phone = Console.ReadLine();
                                        Utility.ValidatePhone(phone);
                                        break;
                                    }
                                    catch (PhoneException ex)
                                    {
                                        Console.WriteLine("Wrong format for phone (start with 0 or 84 and follow by 9 numbers)!");
                                        continue;
                                    }

                                }
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("Enter email: ");
                                         email = Console.ReadLine();
                                        Utility.ValidateEmail(email);
                                        break;
                                    }
                                    catch (PhoneException ex)
                                    {
                                        Console.WriteLine("Wrong format for email !");
                                        continue;
                                    }

                                }                            
                                Console.WriteLine("Enter year of experience: ");
                                int Exyear= Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter pro skill: ");
                                string skill =Console.ReadLine();
                                Employee experience = new Experience(id,fullname, DateTime.Parse(birthday), phone,email,0,manager.GetAllEmployees().Count+1,
                                    new List<Certificate>(),Exyear,skill
                                    );
                                Console.WriteLine("Enter number of certificate");
                                int certificateNumber = Convert.ToInt32(Console.ReadLine());
                                for (int i = 0; i < certificateNumber; i++)
                                {
                                    Console.WriteLine("Enter CertificateId: ");
                                    int certificateId = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter Certificate Name: ");
                                    string certificateName = Console.ReadLine();
                                    Console.WriteLine("Enter Certificate rank: ");
                                    int certificateRank = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter Certificate date: ");
                                    string certificateDate = Console.ReadLine();
                                    Utility.ValidateDate(certificateDate);
                                    experience.Certificates.Add(new Certificate(certificateId, certificateName, certificateRank, DateTime.Parse(certificateDate)));                                                                 
                                }
                                manager.AddNewEmployee(experience);
                                Console.WriteLine(experience.Employee_count);

                            
                            
                            break;
                        }
                    case "b":
                        {
                            
                                Console.WriteLine("Enter ID: ");
                                int id = Convert.ToInt32(Console.ReadLine());
                            string fullname;
                            string birthday;
                            string phone;
                            string email;
                            
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Enter full name: ");
                                    fullname = Console.ReadLine();
                                    Utility.ValidateFullName(fullname);
                                    break;
                                }
                                catch (FullNameException ex)
                                {
                                    Console.WriteLine("Wrong format for full name!");
                                    continue;
                                }

                            }
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Enter birth day: ");
                                    birthday = Console.ReadLine();
                                    Utility.ValidateDate(birthday);
                                    break;
                                }
                                catch (BirthdayException ex)
                                {
                                    Console.WriteLine("Wrong format for birthday (dd/MM/yyyy)!");
                                    continue;
                                }
                            }
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Enter phone: ");
                                    phone = Console.ReadLine();
                                    Utility.ValidatePhone(phone);
                                    break;
                                }
                                catch (PhoneException ex)
                                {
                                    Console.WriteLine("Wrong format for phone (start with 0 or 84 and follow by 9 numbers)!");
                                    continue;
                                }

                            }
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Enter email: ");
                                    email = Console.ReadLine();
                                    Utility.ValidateEmail(email);
                                    break;
                                }
                                catch (PhoneException ex)
                                {
                                    Console.WriteLine("Wrong format for email !");
                                    continue;
                                }

                            }
                            Console.WriteLine("Enter graduation date : ");
                                string graduationDate = Console.ReadLine();
                                Utility.ValidateDate(graduationDate);
                                Console.WriteLine("Enter graduation rank : ");
                                string rank = Console.ReadLine();
                                Console.WriteLine("Enter university name : ");
                                string universityName = Console.ReadLine();
                                Employee fresher = new Fresher(id, fullname, DateTime.Parse(birthday), phone, email, 1, manager.GetAllEmployees().Count + 1,
                                    new List<Certificate>(), DateTime.Parse(graduationDate), rank,universityName
                                    );

                                Console.WriteLine("Enter number of certificate");
                                int certificateNumber = Convert.ToInt32(Console.ReadLine());
                                for (int i = 0; i < certificateNumber; i++)
                                {
                                    Console.WriteLine("Enter CertificateId: ");
                                    int certificateId = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter Certificate Name: ");
                                    string certificateName = Console.ReadLine();
                                    Console.WriteLine("Enter Certificate rank: ");
                                    int certificateRank = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter Certificate date: ");
                                    string certificateDate = Console.ReadLine();
                                    Utility.ValidateDate(certificateDate);
                                    fresher.Certificates.Add(new Certificate(certificateId, certificateName, certificateRank, DateTime.Parse(certificateDate)));
                                }
                                manager.AddNewEmployee(fresher);

                                                      
                            break ;
                        }
                    case "c":
                        {
                            
                                Console.WriteLine("Enter ID: ");
                                int id = Convert.ToInt32(Console.ReadLine());
                            string fullname;
                            string birthday;
                            string phone;
                            string email;
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Enter full name: ");
                                    fullname = Console.ReadLine();
                                    Utility.ValidateFullName(fullname);
                                    break;
                                }
                                catch (FullNameException ex)
                                {
                                    Console.WriteLine("Wrong format for full name!");
                                    continue;
                                }

                            }
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Enter birth day: ");
                                    birthday = Console.ReadLine();
                                    Utility.ValidateDate(birthday);
                                    break;
                                }
                                catch (BirthdayException ex)
                                {
                                    Console.WriteLine("Wrong format for birthday (dd/MM/yyyy)!");
                                    continue;
                                }
                            }
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Enter phone: ");
                                    phone = Console.ReadLine();
                                    Utility.ValidatePhone(phone);
                                    break;
                                }
                                catch (PhoneException ex)
                                {
                                    Console.WriteLine("Wrong format for phone (start with 0 or 84 and follow by 9 numbers)!");
                                    continue;
                                }

                            }
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Enter email: ");
                                    email = Console.ReadLine();
                                    Utility.ValidateEmail(email);
                                    break;
                                }
                                catch (PhoneException ex)
                                {
                                    Console.WriteLine("Wrong format for email !");
                                    continue;
                                }

                            }
                            Console.WriteLine("Enter majors : ");
                                string majors = Console.ReadLine();
                                Console.WriteLine("Enter semester : ");
                                int semester =Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter university name : ");
                                string universityName = Console.ReadLine();
                                Employee fresher = new Intern(id, fullname, DateTime.Parse(birthday), phone, email, 2, manager.GetAllEmployees().Count + 1,
                                    new List<Certificate>(), majors, semester, universityName
                                    );

                                Console.WriteLine("Enter number of certificate");
                                int certificateNumber = Convert.ToInt32(Console.ReadLine());
                                for (int i = 0; i < certificateNumber; i++)
                                {
                                    Console.WriteLine("Enter CertificateId: ");
                                    int certificateId = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter Certificate Name: ");
                                    string certificateName = Console.ReadLine();
                                    Console.WriteLine("Enter Certificate rank: ");
                                    int certificateRank = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Enter Certificate date: ");
                                    string certificateDate = Console.ReadLine();
                                    Utility.ValidateDate(certificateDate);
                                    fresher.Certificates.Add(new Certificate(certificateId, certificateName, certificateRank, DateTime.Parse(certificateDate)));
                                }
                                manager.AddNewEmployee(fresher);
                            break;
                        }
                }
                break;
            }
        case "2":
            {
                Console.WriteLine("Enter employeeId: ");
                int employeeId = Convert.ToInt32(Console.ReadLine());
                if (manager.CheckEmployeeExist(employeeId))
                {
                    string fullname;
                    string birthday;
                    string phone;
                    string email;
                    Console.WriteLine("Enter ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Enter full name: ");
                            fullname = Console.ReadLine();
                            Utility.ValidateFullName(fullname);
                            break;
                        }
                        catch (FullNameException ex)
                        {
                            Console.WriteLine("Wrong format for full name!");
                            continue;
                        }

                    }
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Enter birth day: ");
                            birthday = Console.ReadLine();
                            Utility.ValidateDate(birthday);
                            break;
                        }
                        catch (BirthdayException ex)
                        {
                            Console.WriteLine("Wrong format for birthday (dd/MM/yyyy)!");
                            continue;
                        }
                    }
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Enter phone: ");
                            phone = Console.ReadLine();
                            Utility.ValidatePhone(phone);
                            break;
                        }
                        catch (PhoneException ex)
                        {
                            Console.WriteLine("Wrong format for phone (start with 0 or 84 and follow by 9 numbers)!");
                            continue;
                        }

                    }
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Enter email: ");
                            email = Console.ReadLine();
                            Utility.ValidateEmail(email);
                            break;
                        }
                        catch (PhoneException ex)
                        {
                            Console.WriteLine("Wrong format for email !");
                            continue;
                        }

                    }
                    manager.UpdateEmployee(employeeId, new Employee(fullname, DateTime.Parse(birthday), phone, email));
                    
                }
                else
                {
                    Console.WriteLine("Employee not exist");
                }

                    break;
            }
        case "3":
            {
                Console.WriteLine("Enter employeeId: ");
                int employeeId = Convert.ToInt32(Console.ReadLine());
                if (manager.CheckEmployeeExist(employeeId))
                { 
                    manager.DeleteEmployee(employeeId);
                }
                else
                {
                    Console.WriteLine("Employee not exist");
                }
                    break;
            }
        case "4":
            {
                Console.WriteLine("Enter type to search");
                Console.WriteLine("a: Experience");
                Console.WriteLine("b: Fresher");
                Console.WriteLine("c: Intern");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "a":
                        {
                            List<Employee> experiences = manager.FindByEmployeeType(0);
                            foreach (var emp in experiences)
                            {
                                Console.WriteLine(emp.ShowInfo());
                                foreach(var certificate in emp.Certificates)
                                {
                                    Console.WriteLine(certificate.ToString());
                                }
                            }
                            break;
                        }
                    case "b":
                        {
                            List<Employee> freshers = manager.FindByEmployeeType(1);
                            foreach (var emp in freshers)
                            {
                                Console.WriteLine(emp.ShowInfo());
                                foreach (var certificate in emp.Certificates)
                                {
                                    Console.WriteLine(certificate.ToString());
                                }
                            }
                            break;
                        }
                    case "c":
                        {
                            List<Employee> interns = manager.FindByEmployeeType(2);
                            foreach (var emp in interns)
                            {
                                Console.WriteLine(emp.ShowInfo());
                                foreach (var certificate in emp.Certificates)
                                {
                                    Console.WriteLine(certificate.ToString());
                                }
                            }
                            break;
                        }
                }
                break;
            }
        case "5":
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