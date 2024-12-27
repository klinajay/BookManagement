using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace BookManagement
{
    internal class BookList
    {
        private Dictionary<int, Book> books;
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

        public void printBooksByLooping()
        {
            foreach (var item in books)
            {
                item.Value.PrintBookInfo();
            }
        }
        public void AddBook(Book book)
        {
            book.BookId = ++counter;
            books[counter] = book;

        }

        public void GetAll(bool useQuerySyntax)
        {
            List<Book> list = new List<Book>();
            if (useQuerySyntax)
            {
                list = (from book in books select book.Value).ToList();
            }
            else
            {
                list = books.Select(book => book.Value).ToList();
            }

            Console.WriteLine($"Total Books are {list.Count}");

        }

        public void GetSingleBook(bool useQuerySyntax)
        {
            List<string> list = new List<string>();

            if (useQuerySyntax)
            {
                list = (from book in books select book.Value.Title).ToList();
            }
            else
            {
                list = books.Select(book => book.Value.Title).ToList();
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void GetBookWithSpecificFields(bool useQuerySyntax)
        {
            List<Book> list = new List<Book>();
            if (useQuerySyntax)
            {
                list = (from book in books
                        select new Book
                        {
                            Title = book.Value.Title,

                            Author = book.Value.Author

                            ,
                        }).ToList();
            }
            else
            {
                list = books.Select(book => new Book
                {
                    Title = book.Value.Title,
                    Author = book.Value.Author,
                }).ToList();
            }

            foreach (var item in list)
            {
                item.PrintBookInfo();
            }
        }

        public void AnonymousClass(bool useQuerySyntax)
        {

            if (useQuerySyntax)
            {
                var list = (from book in books
                            select new
                            {
                                Identifier = book.Value.BookId,
                                BookName = book.Value.Title,
                            }).ToList();

                foreach (var item in list)
                {
                    Console.WriteLine($"{nameof(item.BookName)} : {item.BookName}");
                    Console.WriteLine($"{nameof(item.Identifier)} : {item.Identifier}");

                }
            }
            else
            {
                var list = books.Select(book => new
                {
                    Identifier = book.Value.BookId,
                    BookName = book.Value.Title,
                }).ToList();
                foreach (var item in list)
                {
                    Console.WriteLine($"{nameof(item.BookName)} : {item.BookName}");
                    Console.WriteLine($"{nameof(item.Identifier)} : {item.Identifier}");

                }
            }
        }
        public void GetOrderedBookInDescending(bool useQuerySyntax)
        {
            List<Book> list = new List<Book>();
            if (useQuerySyntax)
            {
                list = (from book in books orderby book.Value.Price descending, book.Value.Title select book.Value).ToList();
            }
            else
            {
                list = books.OrderByDescending(book => book.Value.Price).ThenBy(book => book.Value.Title).Select(book => book.Value).ToList();
            }
            foreach (var item in list)
            {
                string serializedBook = JsonSerializer.Serialize(item, new JsonSerializerOptions
                {
                    WriteIndented = true // Makes JSON readable
                });
                item.PrintBookInfo();
                Console.WriteLine(serializedBook);
            }
        }
        public void GetOrderedBooks(bool useQuerySyntax)
        {
            List<Book> list = new List<Book>();
            if (useQuerySyntax)
            {
                list = (from book in books orderby book.Value.BookId select book.Value).ToList();
            }
            else
            {
                list = books.OrderBy(book => book.Value.BookId).Select(book => book.Value).ToList();
            }
            foreach (var item in list)
            {
                string serializedBook = JsonSerializer.Serialize(item, new JsonSerializerOptions
                {
                    WriteIndented = true // Makes JSON readable
                });

                Console.WriteLine(serializedBook);
            }
        }

        public void GetBookByTwoWhere(bool useQuerySyntax)
        {
            List<Book> list = new List<Book>();
            if (useQuerySyntax)
            {
                list = (from book in books where book.Value.Author == "J. Doe" && book.Value.Price < 5000 select book.Value).ToList();
            }
            else
            {
                list = books.Where(book => book.Value.Author == "J. Doe" && book.Value.Price < 5000).Select(book => book.Value).ToList();
            }
            foreach (var item in list)
            {
                string serializedBook = JsonSerializer.Serialize(item, new JsonSerializerOptions
                {
                    WriteIndented = true // Makes JSON readable
                });

                Console.WriteLine(serializedBook);
            }
        }
        public void GetBookByExtensionMethod(bool useQuerySyntax, double price)
        {
            List<Book> list = new List<Book>();
            if (useQuerySyntax)
            {
                list = (from book in books select book.Value).ByPrice(price).ToList();
            }
            else
            {
                list = books.Select(book => book.Value).ByPrice(price).ToList();
            }
            foreach (var item in list)
            {
                string serializedBook = JsonSerializer.Serialize(item, new JsonSerializerOptions
                {
                    WriteIndented = true // Makes JSON readable
                });

                Console.WriteLine(serializedBook);
            }
        }

        public void GetSingleBook(bool useQuerySyntax, double price)
        {
            Book book1 = new Book();
            if (useQuerySyntax)
            {
                book1 = (from book in books where book.Value.Price < price select book.Value).SingleOrDefault();
            }
            else
            {
                book1 = books.Select(book => book.Value).SingleOrDefault(book => book.Price < price);
            }
            
            if (book1 != null)
            {
                string serializedBook = JsonSerializer.Serialize(book1, new JsonSerializerOptions
                {
                    WriteIndented = true // Makes JSON readable
                });
                Console.WriteLine(serializedBook);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        public void AssigningValueToField(bool useQuerySyntax,double tax)
        {
            
            if (useQuerySyntax)
            {
                books = (from book in books let price = book.Value.Price = (tax + book.Value.Price) select book).ToDictionary();
            }
            else
            {
                foreach (var key in books.Keys.ToList())
                {
                    books[key].Price += tax;
                }
            }
            
            foreach (var item in books)
            {
                string serializedBook = JsonSerializer.Serialize(item, new JsonSerializerOptions
                {
                    WriteIndented = true // Makes JSON readable
                });

                Console.WriteLine(serializedBook);
            }
        }
        public void GetTotalAvailableBooksInLibrary(bool useQuerySyntax)
        {
            int noOfBooks = 0;

            if (useQuerySyntax)
            {
                noOfBooks = (from book in books select book.Value).Sum(book => book.AvailableQuantity);
            }
            else
            {
                noOfBooks = books.Select(book => book.Value).Sum(book => book.AvailableQuantity);
            }


                Console.WriteLine($"Total Available Books in Library are {noOfBooks}");

        }
        public void GetBooksByTake(bool useQuerySyntax)
        {
            List<Book> list = new List<Book>();
            if (useQuerySyntax)
            {
                list = (from book in books select book.Value).Take(2).ToList();
            }
            else
            {
                list = books.Select(book => book.Value).Take(2).ToList();
            }
            foreach (var item in list)
            {
                string serializedBook = JsonSerializer.Serialize(item, new JsonSerializerOptions
                {
                    WriteIndented = true // Makes JSON readable
                });
                Console.WriteLine(serializedBook);
            }
        }
        public void GetBooksBySkipWhile(bool useQuerySyntax)
        {
            List<Book> list = new List<Book>();
            if (useQuerySyntax)
            {
                list = (from book in books select book.Value).SkipWhile(book => book.Price < 500).ToList();
            }
            else
            {
                list = books.Select(book => book.Value).SkipWhile(book => book.Price < 500).ToList();
            }
            foreach (var item in list)
            {
                string serializedBook = JsonSerializer.Serialize(item, new JsonSerializerOptions
                {
                    WriteIndented = true // Makes JSON readable
                });
                Console.WriteLine(serializedBook);
            }
        }

        public void GetBookByContains(bool useQuerySyntax, int id)
        {
            bool value;
            BookComparator bookComparator = new BookComparator();
            Book book1 = new Book()
            {
                BookId = id,
            };
            if (useQuerySyntax)
            {
                value = (from book in books select book.Value).Contains(book1, bookComparator);
            }
            else
            {
                value = books.Select(book => book.Value).Contains(book1, bookComparator);
            }

            if (value)
            {
                Console.WriteLine("Book is present in the list");
            }
            else
            {
                Console.WriteLine("Book is not present in the list");
            } 
        }

        public void PrintBooksInList()
        {
            if (counter == 0) { Console.WriteLine("No book is there."); return; }
            Console.WriteLine($"{"Title",-20} {"Author",-20} {"Quantity",-10} {"Price",-10} {"BookId",-10}");
            Console.WriteLine("-------------------------------------------------------------------");

            // Print each book's details
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Value.Title,-20} {book.Value.Author,-20} {book.Value.AvailableQuantity,-10} {book.Value.Price,-10:C} {book.Value.BookId,-10}");
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
                books.GetBooksList()[transaction.BookIssued.BookId].AvailableQuantity += 1;
                Console.WriteLine("Book Returned successfuly.");
            }
        }
        public void IssueBook(ref Borrower borrower,ref Book book)
        {

            if (books.ContainsKey(book.BookId))
            {
                if (books[book.BookId].AvailableQuantity > 0)
                {
                    BorrowTransaction transaction = new BorrowTransaction(book);
                    transaction.IsReturned = false;
                    transaction.IssueDate = DateTime.Now;
                    borrower.PushTransactionToHistory(transaction);
                    books[book.BookId].AvailableQuantity -= 1;
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

