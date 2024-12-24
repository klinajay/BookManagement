using System;
using System.Collections.Generic;
using System.Linq;
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

        public BorrowTransaction(Book book, DateTime issueDate, DateTime returnDate, bool isReturned, int transactionId)
        {
            this.bookIssued = book;
            this.issueDate = issueDate;
            this.returnDate = returnDate;
            this.isReturned = isReturned;
            this.transactionId = transactionId;
        }

        public Book BookIssued { get { return bookIssued; } set { bookIssued = value; } }
        public DateTime IssueDate { get { return issueDate; } set { issueDate = value; } }
        public DateTime ReturnDate { get { return returnDate; } set { returnDate = value; } }
        public bool IsReturned { get { return isReturned; } set { isReturned = value; } }
        public int TransactionId { get { return transactionId; } set { transactionId = value; } }


    }
}
