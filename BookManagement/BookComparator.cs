using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    internal class BookComparator : EqualityComparer<Book>
    {
        public override bool Equals(Book x, Book y)
        {
            if(x.BookId == y.BookId && x.Title == y.Title && x.Author == y.Author && x.AvailableQuantity == y.AvailableQuantity && x.Price == y.Price)
            {
                Console.WriteLine(x.BookId + " " + y.BookId);
                Console.WriteLine(x.Title + " " + y.Title);
                Console.WriteLine(x.BookId + " " + y.BookId);
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode(Book obj)
        {
            return obj.BookId;
        }
    }
}
