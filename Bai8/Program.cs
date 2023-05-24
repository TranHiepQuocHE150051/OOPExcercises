
using Bai8;

CardManager manager = new CardManager();
Console.WriteLine("Library Card Management System");
while (true)
{
    Console.WriteLine("1: Add new card");
    Console.WriteLine("2: Remove card");
    Console.WriteLine("3: Get All card information");
    Console.WriteLine("4: Exit");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            {
                Console.WriteLine("Enter Card Id: ");
                int cardId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter borrow date: ");
                int borrowdate=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter return date: ");
                int returndate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter book no: ");
                int bookno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter student name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter student age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter student grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                Student student = new Student(name, age, grade);
                Card card = new Card(cardId, borrowdate, returndate, bookno, student);
                manager.AddNewCard(card);
                break;
            }
        case "2":
            {
                Console.WriteLine("Enter card id");
                int cardId =Convert.ToInt32(Console.ReadLine());
                manager.RemoveCard(cardId);

                break;
            }
        case "3":
            {
                List<Card> cards = manager.GetAllCards();
                foreach(var card in cards)
                {
                    Console.WriteLine(card.ToString());
                }
                break;
            }
        case "4":
            {
                return;
            }
    }
}
