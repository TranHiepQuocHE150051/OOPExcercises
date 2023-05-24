using Bai6;

SchoolManagement manager = new SchoolManagement();
Console.WriteLine("School Management System");
while (true)
{
    Console.WriteLine("1: Add new student");
    Console.WriteLine("2: Students Information");
    Console.WriteLine("3: Find student by age");
    Console.WriteLine("4: Get numbers of student by age & hometown");
    Console.WriteLine("5: Exit");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            {
                Console.WriteLine("Enter grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Full Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter home town: ");
                string hometown = Console.ReadLine();
                Student student = new Student(grade, name, age, hometown);
                manager.AddNewStudent(student);
                break;
            }
        case "2":
            {
                List<Student> students= manager.GetAllStudents();
                foreach (var student in students)
                {
                    Console.WriteLine(student.ToString());
                }
                break;
            }
        case "3":
            {
                Console.WriteLine("Enter age: ");
                int age= Convert.ToInt32(Console.ReadLine());
                List<Student> students= manager.GetStudentsByAge(age);
                foreach (var student in students)
                {
                    Console.WriteLine(student.ToString());
                }
                break;
            }
        case "4":
            {
                Console.WriteLine("Enter age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter hometown: ");
                string hometown = Console.ReadLine();
                int result = manager.GetNumberOfStudents(age, hometown);
                if(result > 0)
                {
                    Console.WriteLine("There are " + result + " students");
                }
                else
                {
                    Console.WriteLine("No result");
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
