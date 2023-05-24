using Bai2;

DocumentManager manager = new DocumentManager();
while (true)
{
    Console.WriteLine("Document Management");
    Console.WriteLine(" 1: Add new document");
    Console.WriteLine(" 2: Delete a document: ");
    Console.WriteLine(" 3: Document Infomation  ");
    Console.WriteLine(" 4: Find document by type  ");
    Console.WriteLine(" 5: Exit ");
    String choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            {
                Console.WriteLine("a: Add new book");
                Console.WriteLine("b: Add new magazine");
                Console.WriteLine("c: Add new newspaper");
                String type = Console.ReadLine();
                switch (type)
                {
                    case "a":
                        {
                            Console.WriteLine("Enter Id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Publisher name :");
                            string publishername = Console.ReadLine();
                            Console.WriteLine("Enter published number: ");
                            int publishednumber = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter author name : ");
                            String authorname = Console.ReadLine();
                            Console.WriteLine("Enter number of pages : ");
                            int pages = Convert.ToInt32(Console.ReadLine());
                            Document book = new Book(id, publishername, publishednumber, authorname, pages);
                            manager.AddNewDocument(book);
                            break;

                        }
                    case "b":
                        {
                            Console.WriteLine("Enter Id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Publisher name :");
                            string publishername = Console.ReadLine();
                            Console.WriteLine("Enter published number: ");
                            int publishednumber = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter released No : ");
                            int releasedNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter released month : ");
                            int releasedMonth = Convert.ToInt32(Console.ReadLine());
                            Document magazine = new Magazine(id, publishername, publishednumber, releasedNo, releasedMonth);
                            manager.AddNewDocument(magazine);
                            break;
                        }
                    case "c":
                        {
                            Console.WriteLine("Enter Id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Publisher name :");
                            string publishername = Console.ReadLine();
                            Console.WriteLine("Enter published number: ");
                            int publishednumber = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter released date : ");
                            String releasedDate = Console.ReadLine();

                            Document newspaper = new Newspaper(id, publishername, publishednumber, releasedDate);
                            manager.AddNewDocument(newspaper);
                            break;
                        }
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                break;
            }
        case "2":
            {
                Console.WriteLine("Enter id of the document you want to delete: ");
                int id= Convert.ToInt32(Console.ReadLine());
                manager.DeleteDocument(id);
                break;
            }
        case "3":
            {
                Console.WriteLine("====Document Information===");
                List<Document> documents = manager.GetDocuments();
                foreach (var document in documents)
                {
                    Console.WriteLine("--------");
                    Console.WriteLine(document.ToString());
                }
                break;
            }
        case "4":
            {
                Console.WriteLine("a: Get Book Information");
                Console.WriteLine("b: Get Magazine Information");
                Console.WriteLine("c: Get Newspaper Information");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "a":
                        {
                            List<Document> books = manager.GetDocuments().Where(d=>d.GetType()== typeof(Book)).ToList();
                            foreach (var book in books)
                            {
                                Console.WriteLine("--------");
                                Console.WriteLine(book.ToString());
                            }
                            break;
                        }
                    case "b":
                        {
                            List<Document> magazines = manager.GetDocuments().Where(d => d.GetType() == typeof(Magazine)).ToList();
                            foreach (var magazine in magazines)
                            {
                                Console.WriteLine("--------");
                                Console.WriteLine(magazine.ToString());
                            }
                            break;
                        }
                    case "c":
                        {
                            List<Document> newspapers = manager.GetDocuments().Where(d => d.GetType() == typeof(Newspaper)).ToList();
                            foreach (var newspaper in newspapers)
                            {
                                Console.WriteLine("--------");
                                Console.WriteLine(newspaper.ToString());
                            }
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
        case "5":
            {

                return;
            }
        default:
            {
                Console.WriteLine("Input is from 1 to 5");
                continue;
            }
    }
}
