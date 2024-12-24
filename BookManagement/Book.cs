namespace BookManagement
{
    internal class Book
    {
        private string title;
        private string author;
        private int availableQuantity;
        private int price;
        private int bookId;

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
       
        public string Title { get { return title; } }
        public string Author { get { return author; } }
        public int Quantity { get { return availableQuantity; } set { availableQuantity = value; } }       
        public int Price { get { return price; } }

        public void PrintBookInfo()
        {
            Console.WriteLine($"Title of Book is: {title}");
            Console.WriteLine($"Author of Book is: {author}");
            Console.WriteLine($"Available quantity of Book is: {availableQuantity}");
            Console.WriteLine($"Price of Book is: {price}");
        }

    }
}
