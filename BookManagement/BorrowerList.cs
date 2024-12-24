using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement
{
    internal class BorrowerList
    {
        private Dictionary<int, Borrower> borrowerDictionary;
        private int count;
        public BorrowerList()
        {
            borrowerDictionary = new Dictionary<int, Borrower>();   
            count = 0;  
        }
        public Dictionary<int, Borrower> GetBorrowerList() { return borrowerDictionary; }
        public void AddBorrwer(Borrower borrower)
        {
            borrowerDictionary[++count] = borrower;
            borrower.Id = count;
        }
        public void updateBorrowerList(Borrower borrower, int id)
        {
            borrowerDictionary[id] = borrower;
        }
    }
}
