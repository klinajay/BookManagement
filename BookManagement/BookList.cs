using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    internal class BookList
    {
        private Dictionary<int , Book> books;
        private int counter;
        public BookList()
        {
            books = new Dictionary<int, Book>();
            counter = 0;
        }

        public Dictionary<int, Book> GetBooksList()
        {
            return books;
        }

        public void AddBook(Book book)
        {
            book.BookId = ++counter;
            books[counter] = book;

        }
        public void PrintBooksInList()
        {
            if (counter == 0) { Console.WriteLine("No book is there."); return; }
            Console.WriteLine($"{"Title",-20} {"Author",-20} {"Quantity",-10} {"Price",-10} {"BookId",-10}");
            Console.WriteLine("-------------------------------------------------------------------");

            // Print each book's details
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Value.Title,-20} {book.Value.Author,-20} {book.Value.Quantity,-10} {book.Value.Price,-10:C} {book.Value.BookId,-10}");
            }
        }
        public void ReturnBook(ref Borrower borrower , ref BookList books)
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
                //borrower.PushTransactionToHistory(transaction);
                books.GetBooksList()[transaction.BookIssued.BookId].Quantity += 1;
                Console.WriteLine("Book Returned successfuly.");
            }
        }
        public void IssueBook(ref Borrower borrower,ref Book book)
        {

            if (books.ContainsKey(book.BookId))
            {
                if (books[book.BookId].Quantity > 0)
                {
                    BorrowTransaction transaction = new BorrowTransaction(book);
                    transaction.IsReturned = false;
                    transaction.IssueDate = DateTime.Now;
                    borrower.PushTransactionToHistory(transaction);
                    books[book.BookId].Quantity -= 1;
                    Console.WriteLine("Book Issued successfuly.");
                }
                else
                {
                    Console.WriteLine("Book is not available.");
                }
                
            }
            else
            {
                Console.WriteLine("Wrong book Id");
            }
               
            
        }
    }
    }

