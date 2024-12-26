namespace BookManagement
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int AvailableQuantity { get; set; }
        public int Price { get; set; }
        public int BookId { get; set; }

        public Book()
        {

        }

        public Book( string Title, string Author, int AvailableQuantity, int Price)
        {
            
            this.Title = Title;
            this.Author = Author;
            this.AvailableQuantity = AvailableQuantity;
            this.Price = Price;
        }

        
       
       
        public void PrintBookInfo()
        {
            Console.WriteLine($"Title of Book is: {Title}");
            Console.WriteLine($"Author of Book is: {Author }");
            Console.WriteLine($"Available quantity of Book is: {AvailableQuantity}");
            Console.WriteLine($"Price of Book is: {Price}");
        }

    }
}
