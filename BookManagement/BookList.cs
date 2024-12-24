using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    internal class BookList
    {
        private Dictionary<int , string> books;
        private int counter;
        public BookList()
        {
            books = new Dictionary<int, string>();
            counter = 0;
        }

        public Dictionary<int, string> GetBooksList()
        {
            return books;
        }

        public void printBooksInList(List<Book> books)
        {
            Console.WriteLine($"{"Title",-20} {"Author",-20} {"Quantity",-10} {"Price",-10} {"BookId",-10}");
            Console.WriteLine("-------------------------------------------------------------------");

            // Print each book's details
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title,-20} {book.Author,-20} {book.Quantity,-10} {book.Price,-10:C} {book.BookId,-10}");
            }
        }
        public void ReturnBook(Borrower borrower , Book book)
        {
            if (borrower.GetBorrowHistory().Count <= 0)
            {
                Console.WriteLine("You have not issued book recently.");
            }
            else
            {
                BorrowTransaction transaction = borrower.GetBorrowHistory().Peek();
                transaction.IsReturned = true;
                transaction.ReturnDate = DateTime.Now;
                borrower.PopTransactionToHistory();
                borrower.PushTransactionToHistory(transaction);
            }
        }
        public void IssueBook(ref Borrower borrower,ref Book book)
        {
           
                BorrowTransaction transaction = new BorrowTransaction(book);
                transaction.IsReturned = false;
                transaction.IssueDate = DateTime.Now;
                borrower.PushTransactionToHistory(transaction);
            
        }
    }
    }

