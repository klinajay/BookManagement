using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    static class CustomFiltering
    {
        public static IEnumerable<Book> ByPrice(this IEnumerable<Book>books,double price)
        {
            List<Book> list = new List<Book>();
            list = books.Where(book => book.Price < price).ToList();
            return list;
        }
    }
}
