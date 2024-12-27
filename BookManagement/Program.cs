using BookManagement;

internal class Program
{
    private static BookList bookList = new BookList();
    private static BorrowerList borrowerList = new BorrowerList();
    private static void Main(string[] args)
    {
        AddDemoData();

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
        //                Book book = bookList.GetBooksList()[id];
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
        bookList.printBooksByLooping();
        //selecting all fields
        bookList.GetAll(true);
        //selecting the single fields
        bookList.GetSingleBook(false);
        //selecting specific columns
        bookList.GetBookWithSpecificFields(true);
        //Anonymous class
        bookList.AnonymousClass(true);
        //orderedby demo
        bookList.GetOrderedBooks(true);
        //orderbydescending and .thenby
        bookList.GetOrderedBookInDescending(false);
        //where condition filtering
        bookList.GetBookByTwoWhere(true);
        //Filtering using custom extension methods
        bookList.GetBookByExtensionMethod(true,500);
        //using SingleorDefault
        bookList.GetSingleBook(true,100);
        //Assigning values to the particular fields
        bookList.AssigningValueToField(true,12);
        //use of sum and foreach function
        bookList.GetTotalAvailableBooksInLibrary(true);
        //use of Take and Skip , TAkeWhile and SkipWhile
        bookList.GetBooksByTake(true);
        Console.WriteLine("SkipWhile Demo");
        bookList.GetBooksBySkipWhile(true);
        Console.WriteLine("Contains Demo");
        bookList.GetBookByContains(true, 4);
    }
    public static void AddDemoData()
    {
        Book book1 = new Book("C# Prog", "J. Doe", 10, 500);
        Book book2 = new Book("Learn LINQ", "J. Smith", 5, 300);
        Book book3 = new Book("ASP.NET Core", "M. Twain", 3, 700);
        Book book4 = new Book("Algorithms", "T. Cormen", 8, 600);
        Book book5 = new Book("Pragmatic Prog", "A. Hunt", 6, 450);
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
}