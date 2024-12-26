namespace BookManagement
{
    internal class Book
    {
        public string title;
        public string author;
        public int availableQuantity;
        public int price;
        public int bookId;

        public Book()
        {

        }

        public Book( string title, string author, int availableQuantity, int price)
        {
            
            this.title = title;
            this.author = author;
            this.availableQuantity = availableQuantity;
            this.price = price;
        }

        public int BookId
        {
            get { return bookId; }
            set
            {
                bookId = value;
            }
        }
       
       
        public void PrintBookInfo()
        {
            Console.WriteLine($"Title of Book is: {title}");
            Console.WriteLine($"Author of Book is: {author}");
            Console.WriteLine($"Available quantity of Book is: {availableQuantity}");
            Console.WriteLine($"Price of Book is: {price}");
        }

    }
}
