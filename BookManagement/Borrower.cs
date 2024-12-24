using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    internal class Borrower
    {
        private string name;
        private int id;
        private string phoneNumber;
        private Stack<BorrowTransaction> borrowHistory;
        
        public Borrower(string name, int id, string phoneNumber)
        {
            this.name = name;  
            this.id = id;
            this.phoneNumber = phoneNumber;
            borrowHistory = new Stack<BorrowTransaction>();

        }

        public string Name { get { return this.name; } set { name = value; } }
        public int Id { get { return this.id; } set { id = value; } }
        public string PhoneNumber { get { return this.name; } set { phoneNumber = value; } }
        public Stack<BorrowTransaction> GetBorrowHistory() { return this.borrowHistory; }
        

        public void PushTransactionToHistory(BorrowTransaction transaction)
        {
            this.borrowHistory.Push(transaction);

        }
        public void PopTransactionToHistory()
        {
            if(this.borrowHistory.Count <= 0)
            {
                Console.WriteLine("You have not issued book recently.");
            }
            else
            {
                this.borrowHistory.Pop();
            }
        }
        public void PrintTransactionHistory()
        {
           foreach(var transaction in this.borrowHistory)
            {
                transaction.PrintTransaction();
            }
        }

    }
}
