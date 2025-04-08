namespace libraryTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("Axundov");
            while (true)
            {
                Console.WriteLine("1. add book");
                Console.WriteLine("2. Get book by id");
                Console.WriteLine("3. Remove book");
                Console.WriteLine("4. Update Book");
                Console.WriteLine("5. Get all books");
                Console.WriteLine("6. Quit");
                Console.WriteLine("Seciminizi daxil edib enter basiniz: ");
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("kitabin adini daxil edin: ");
                        string bookName = Console.ReadLine();
                        Console.WriteLine("authorName daxil edin: ");
                        string authorName = Console.ReadLine();
                        Console.WriteLine("qiymet daxil edin: ");
                        double bookPrice;
                        while(!double.TryParse(Console.ReadLine(),out bookPrice) || bookPrice < 0)
                        {
                            Console.WriteLine("Qiymeti duzgun qeyd ele!!!");
                            Console.WriteLine("qiymet daxil ele");
                        }
                        Book book = new Book(bookName, authorName, bookPrice);
                        library.AddBook(book);
                        Console.WriteLine($"{bookName} kitabi yaradildi ve {library.Name} kitabxanasina elave olundu.");
                        break;
                    case "2":
                        Console.WriteLine("istediyiniz kitabin Idsini daxil edin: ");
                        int bookId;
                        while (!int.TryParse(Console.ReadLine(), out bookId))
                        {
                            Console.WriteLine("Id ni duzgun daxil ele!! ");
                            Console.WriteLine("Id daxil ele");
                        }
                       
                        Console.WriteLine(library.GetBookById(bookId));
                        break;
                    case "3":
                        Console.WriteLine("Silmek istediyiniz kitabin id sini daxil edin: ");
                        int bookunIdsi;
                        while (!int.TryParse(Console.ReadLine(), out bookunIdsi))
                        {
                            Console.WriteLine("Id ni duzgun daxil ele!!");
                            Console.WriteLine("Id daxil ele: ");

                        }
                        library.RemoveBook(bookunIdsi);
                        Console.WriteLine($"{bookunIdsi} id li kitab silindi");
                        break;
                    case "4":
                        Console.WriteLine("kitabin adini daxil edin: ");
                        string bookunAdi = Console.ReadLine();
                        Console.WriteLine("authorName daxil edin: ");
                        string authorunAdi = Console.ReadLine();
                        Console.WriteLine("qiymet daxil edin: ");
                        double bookunPricei;
                        while (!double.TryParse(Console.ReadLine(), out bookunPricei) || bookunPricei < 0)
                        {
                            Console.WriteLine("Qiymeti duzgun qeyd ele!!!");
                            Console.WriteLine("qiymet daxil ele");
                        }
                        Book Book = new Book(bookunAdi, authorunAdi, bookunPricei);
                        int evezolunanId;
                        while (!int.TryParse(Console.ReadLine(), out evezolunanId))
                        {
                            Console.WriteLine("Id ni duzgun daxil edin: ");
                            Console.WriteLine("evez elemek istediyiniz kitabin id sini daxil edin: ");
                        }
                        Console.WriteLine("Bu kitabi hansi id li kitabnan evez etmek isteyirsizse onun id sini yazin: ");
                        library.Update(evezolunanId, Book);
                        Console.WriteLine($"{bookunAdi} kitabi yaradildi ve {library.Name} kitabxanasina elave olundu.");
                        break;
                    case "5":
                        library.GetAllBooks();
                        break;
                    case "0":
                        return;
                        break;
                }
            }
        }
    }
}
