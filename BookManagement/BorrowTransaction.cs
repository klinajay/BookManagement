using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    internal class BorrowTransaction
    {
        private Book bookIssued;
        private DateTime issueDate;
        private DateTime returnDate;
        private bool isReturned;
        private int transactionId;
        int count = 0;

        public BorrowTransaction(Book book)
        {
            this.bookIssued = book;
            this.transactionId = ++count;
        }

        public Book BookIssued { get { return bookIssued; } set { bookIssued = value; } }
        public DateTime IssueDate { get { return issueDate; } set { issueDate = value; } }
        public DateTime ReturnDate { get { return returnDate; } set { returnDate = value; } }
        public bool IsReturned { get { return isReturned; } set { isReturned = value; } }
        public int TransactionId { get { return transactionId; } set { transactionId = value; } }

        public void PrintTransaction()
        {
            // Assuming bookIssued is a valid object and Title is a string property
            string isReturn;
            if (IsReturned) isReturn = "Yes";
            else isReturn = "No";
            Console.WriteLine($"{transactionId,-10} {bookIssued.Title,-30} {isReturn,-5} {issueDate,-15} {ReturnDate,-15}");

        }
    }
}
