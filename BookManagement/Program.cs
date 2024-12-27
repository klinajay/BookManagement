using BookManagement;

internal class Program
{
    private static BookList bookList = new BookList();
    private static BorrowerList borrowerList = new BorrowerList();
    private static void Main(string[] args)
    {
        AddDemoData(bookList);

        Console.WriteLine("**************Welcome to Book Management App*****************");
        //Console.Write("Enter your id.");
        //int.TryParse(Console.ReadLine(), out int borrowerId);
        //Console.WriteLine("Enter proper action number.");
        //Console.WriteLine("1: Issue Book 2: Return Book 3:View Borrow history");
        //int.TryParse(Console.ReadLine(), out int action);

        //do
        //{

        //    switch (action)
        //    {
        //        case 1:
        //            {
        //                Console.Write("Enter id of book.");
        //                int.TryParse(Console.ReadLine(),out int id);

        //                Borrower borrower = borrowerList.GetBorrowerList()[borrowerId];
        //                Book book = bookList[id];
        //                bookList.IssueBook(ref borrower, ref book);
        //                borrowerList.updateBorrowerList(borrower,borrowerId);
        //                break;

        //            }
        //            case 2:
        //            {

        //                Borrower borrower = borrowerList.GetBorrowerList()[borrowerId];
        //                bookList.ReturnBook(ref borrower, ref bookList);
        //                borrowerList.updateBorrowerList(borrower, borrowerId);
        //                break;

        //            }
        //        case 3:
        //            {

        //                Borrower borrower = borrowerList.GetBorrowerList()[borrowerId];
        //                borrower.PrintTransactionHistory();
        //                break;
        //            }
        //    }
        //    Console.WriteLine("1: Issue Book 2: Return Book 3:View Borrow history");
        //    int.TryParse(Console.ReadLine(), out  action);
        //}
        //while (action <= 3 && action > 0);
        //Console.WriteLine("Hello, World!");
        //bookList.printBooksByLooping();
        ////selecting all fields
        //bookList.GetAll(true);
        ////selecting the single fields
        //bookList.GetSingleBook(false);
        ////selecting specific columns
        //bookList.GetBookWithSpecificFields(true);
        ////Anonymous class
        //bookList.AnonymousClass(true);
        ////orderedby demo
        //bookList.GetOrderedBooks(true);
        ////orderbydescending and .thenby
        //bookList.GetOrderedBookInDescending(false);
        ////where condition filtering
        //bookList.GetBookByTwoWhere(true);
        ////Filtering using custom extension methods
        //bookList.GetBookByExtensionMethod(true,500);
        ////using SingleorDefault
        //bookList.GetSingleBook(true,100);
        ////Assigning values to the particular fields
        //bookList.AssigningValueToField(true,12);
        ////use of sum and foreach function
        //bookList.GetTotalAvailableBooksInLibrary(true);
        //use of Take and Skip , TAkeWhile and SkipWhile
        //bookList.GetBooksByTake(true);
        //Console.WriteLine("SkipWhile Demo");
        //bookList.GetBooksBySkipWhile(true);
        //Console.WriteLine("Contains Demo");
        //bookList.GetBookByContains(true, 4);
        //Console.WriteLine("SequenceEqual Demo");
        //Console.WriteLine();
        //bookList.EqualOrNotBooklists(true);
        //Console.WriteLine("Except Demo");
        //Console.WriteLine();
        //bookList.GetBookListDifference(true);
        //Console.WriteLine("Inner Join Demo");
        //bookList.GetBookByInnerJoin(false);
        //Console.WriteLine("Group Demo");

        //bookList.GetBooksByGroupJoin(true);

        //Console.WriteLine("Left Join Demo");
        //bookList.GetBooksByUingLeftOuterJoin(true);
        Console.WriteLine("GroupBy Demo");
        bookList.GroupBooksUsingGroupBy(true);
    }
    public static void AddDemoData(BookList bookList)
    {
        Book book1 = new Book("C# Prog", "J. Doe", 10, 500);
        Book book2 = new Book("Learn LINQ", "J. Smith", 5, 300);
        Book book3 = new Book("ASP.NET Core", "M. Twain", 3, 700);
        Book book4 = new Book("Algorithms", "T. Cormen", 8, 600);
        Book book5 = new Book("Pragmatic Prog", "A. Hunt", 6, 450);
        Book book6 = new Book("Design Patterns", "E. Gamma", 12, 750);
        Book book7 = new Book("Clean Code", "R. Martin", 15, 550);
        Book book8 = new Book("Effective C#", "B. Wagner", 9, 650);
        Book book9 = new Book("Refactoring", "M. Fowler", 7, 600);
        Book book10 = new Book("Head First Design Patterns", "E. Freeman", 10, 500);
        Book book11 = new Book("C# in Depth", "J. Skeet", 5, 850);
        Book book12 = new Book("You Don't Know JS", "K. Simpson", 8, 400);
        Book book13 = new Book("Introduction to Algorithms", "T. Cormen", 4, 950);
        Book book14 = new Book("Domain-Driven Design", "E. Evans", 6, 700);
        Book book15 = new Book("The Art of Computer Programming", "D. Knuth", 3, 1200);

        bookList.AddBook(book1);
        bookList.AddBook(book6);
        bookList.AddBook(book7);
        bookList.AddBook(book8);
        bookList.AddBook(book9);
        bookList.AddBook(book10);
        bookList.AddBook(book11);
        bookList.AddBook(book12);
        bookList.AddBook(book13);
        bookList.AddBook(book14);
        bookList.AddBook(book15);
        bookList.AddBook(book1);
        bookList.AddBook(book2);
        bookList.AddBook(book3);
        bookList.AddBook(book4);
        bookList.AddBook(book5);
        Borrower b1 = new Borrower("Alice Johnson", 1, "123-456-7890");
        Borrower b2 = new Borrower("Bob Smith", 2, "234-567-8901");
        Borrower b3 = new Borrower("Charlie Brown", 3, "345-678-9012");
        Borrower b4 = new Borrower("David Wilson", 4, "456-789-0123");
        Borrower b5 = new Borrower("Eve Davis", 5, "567-890-1234");
        borrowerList.AddBorrwer(b1);
        borrowerList.AddBorrwer(b2);
        borrowerList.AddBorrwer(b3);
        borrowerList.AddBorrwer(b4);
        borrowerList.AddBorrwer(b5);
        //bookList.PrintBooksInList();
    }
    public static void AddDemoData2(BookList bookList)
    {
        Book book8 = new Book("Effective C#", "B. Wagner", 9, 650);
        Book book9 = new Book("Refactoring", "M. Fowler", 7, 600);
        Book book10 = new Book("Head First Design Patterns", "E. Freeman", 10, 500);
        Book book11 = new Book("C# in Depth", "J. Skeet", 5, 850);
        Book book12 = new Book("You Don't Know JS", "K. Simpson", 8, 400);
        Book book13 = new Book("Introduction to Algorithms", "T. Cormen", 4, 950);
        Book book14 = new Book("Domain-Driven Design", "E. Evans", 6, 700);
        Book book15 = new Book("The Art of Computer Programming", "D. Knuth", 3, 1200);
        bookList.AddBook(book10);
        bookList.AddBook(book11);
        bookList.AddBook(book12);
        bookList.AddBook(book13);
        bookList.AddBook(book14);
        bookList.AddBook(book15);
        Borrower b1 = new Borrower("Alice Johnson", 1, "123-456-7890");
        Borrower b2 = new Borrower("Bob Smith", 2, "234-567-8901");
        Borrower b3 = new Borrower("Charlie Brown", 3, "345-678-9012");
        Borrower b4 = new Borrower("David Wilson", 4, "456-789-0123");
        Borrower b5 = new Borrower("Eve Davis", 5, "567-890-1234");
        borrowerList.AddBorrwer(b1);
        borrowerList.AddBorrwer(b2);
        borrowerList.AddBorrwer(b3);
        borrowerList.AddBorrwer(b4);
        borrowerList.AddBorrwer(b5);
        //bookList.PrintBooksInList();
    }
    public static void AddDemoData3(BookList bookList)
    {
        Book book1 = new Book("C# Prog", "J. Doe", 10, 500);
        Book book2 = new Book("Learn LINQ", "J. Doe", 5, 300); // Same author as book1
        Book book3 = new Book("ASP.NET Core", "M. Twain", 3, 700);
        Book book4 = new Book("Algorithms", "T. Cormen", 8, 600);
        Book book5 = new Book("Pragmatic Prog", "A. Hunt", 6, 450);
        Book book6 = new Book("Design Patterns", "E. Gamma", 12, 750);
        Book book7 = new Book("Clean Code", "R. Martin", 15, 550);
        Book book8 = new Book("Effective C#", "R. Martin", 9, 650); // Same author as book7
        Book book9 = new Book("Refactoring", "M. Fowler", 7, 600);
        Book book10 = new Book("Head First Design Patterns", "E. Freeman", 10, 500);
        Book book11 = new Book("C# in Depth", "J. Skeet", 5, 850);
        Book book12 = new Book("You Don't Know JS", "K. Simpson", 8, 400);
        Book book13 = new Book("Introduction to Algorithms", "T. Cormen", 4, 950); // Same author as book4
        Book book14 = new Book("Domain-Driven Design", "E. Evans", 6, 700);
        Book book15 = new Book("The Art of Computer Programming", "D. Knuth", 3, 1200);

        bookList.AddBook(book1);
        bookList.AddBook(book2); // Duplicate author J. Doe
        bookList.AddBook(book3);
        bookList.AddBook(book4);
        bookList.AddBook(book5);
        bookList.AddBook(book6);
        bookList.AddBook(book7);
        bookList.AddBook(book8); // Duplicate author R. Martin
        bookList.AddBook(book9);
        bookList.AddBook(book10);
        bookList.AddBook(book11);
        bookList.AddBook(book12);
        bookList.AddBook(book13); // Duplicate author T. Cormen
        bookList.AddBook(book14);
        bookList.AddBook(book15);
    }
}