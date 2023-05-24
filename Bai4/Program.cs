using Bai4;

Console.WriteLine("Town Management");
Console.WriteLine("Enter number of families in town: ");
int number = Convert.ToInt32(Console.ReadLine());
Town town = new Town(new List<Family>());
for(int i = 0; i < number; i++)
{
    Console.WriteLine("Enter number of members in family: ");
    int memberNo=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter apartment number: ");
    int apartmentNumber = Convert.ToInt32(Console.ReadLine());
    Family family = new Family(memberNo,apartmentNumber,new List<Person>());
    for (int j = 0; j < memberNo; j++)
    {
        Console.WriteLine("Enter Full name: ");
        string Fullname = Console.ReadLine();
        Console.WriteLine("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter job: ");
        string job = Console.ReadLine();
        Console.WriteLine("Enter identity number: ");
        string inum= Console.ReadLine();
        family.MembersInfo.Add(new Person(Fullname, age, job, inum));
    }
    town.Families.Add(family);
}
Console.WriteLine("Town Information");
Console.WriteLine("Number of families: " + town.Families.Count);
Console.WriteLine("Family Information");
foreach(var family in town.Families)
{
    Console.WriteLine("----------------");
    Console.WriteLine("Number of members: "+family.MembersNo);
    Console.WriteLine("Apartment No: "+family.ApartmentNo);
    Console.WriteLine("Member information");
    foreach (var person in family.MembersInfo)
    {
        Console.WriteLine("Full name: "+person.Name);
        Console.WriteLine("Age: "+person.Age);
        Console.WriteLine("Job: "+person.Job);
        Console.WriteLine("Identity Number: "+person.IdentityNumber);
    }
}


