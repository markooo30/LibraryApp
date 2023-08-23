namespace LibraryApp
{
    public class Program
    {
        static void Main()
        {
            Library library = new Library();

            
            Book book1 = new Book
            {
                Title = "Harry Potter and the Sorcerer's Stone",
                Author = "J.K. Rowling",
                ISBN = "978-0590353427",
                IsAvailable = true
            };

            Book book2 = new Book
            {
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                ISBN = "978-0061120084",
                IsAvailable = true
            };

            Book book3 = new Book
            {
                Title = "1984",
                Author = "George Orwell",
                ISBN = "978-0451524935",
                IsAvailable = true
            };

            Book book4 = new Book
            {
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                ISBN = "978-0743273565",
                IsAvailable = true
            };

            Book book5 = new Book
            {
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                ISBN = "978-0141439518",
                IsAvailable = true
            };

            
            User user1 = new User
            {
                Name = "Alice",
                Email = "alice@example.com"
            };

            User user2 = new User
            {
                Name = "Bob",
                Email = "bob@example.com"
            };

            User user3 = new User
            {
                Name = "Charlie",
                Email = "charlie@example.com"
            };

            User user4 = new User
            {
                Name = "David",
                Email = "david@example.com"
            };

            
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

            library.AddUser(user1);
            library.AddUser(user2);
            library.AddUser(user3);
            library.AddUser(user4);

            Console.WriteLine("......................................");

            library.LoadData();

           
            library.Start();
        }
    }
}
// EXTENDED
//Save Lists to Files
//▸ Extend your Library Management System to include the capability to save the lists of books, users, and transactions
//to separate files. When the program starts, load data from these files if they exist. When the program ends, save the
//updated lists to the respective files.
//▸ Tasks:
//▹ Implement methods to save the list of books, users, and transactions to separate text files. Each file should
//contain the necessary information to recreate the objects.
//▹ When the program starts, check if the files for books, users, and transactions exist. If they do, load the data
//from these files to initialize your lists.
//▹ When the program ends (e.g., when the user selects the "Exit" option), save the current lists of books, users,
//and transactions back to their respective files.
//▹ Ensure that your program continues to work seamlessly with the added file I/O functionalities.
