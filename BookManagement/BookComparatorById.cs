using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    internal class BookComparatorById : EqualityComparer<Book>
    {
        public BookComparatorById()
        {

        }
        public override bool Equals(Book x, Book y)
        {
            if (x == null || y == null)
            {
                return false;
            }
            return x.BookId == y.BookId;

        }
        public override int GetHashCode(Book obj) { 
            return obj.BookId;
        }
    }
}
