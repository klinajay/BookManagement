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
        
        public Borrower(string name, int id, string phoneNumber)
        {
            this.name = name;  
            this.id = id;
            this.phoneNumber = phoneNumber;
        }

        public string Name { get { return this.name; } set { name = value; } }
        public int Id { get { return this.id; } set { id = value; } }
        public string PhoneNumber { get { return this.name; } set { phoneNumber = value; } }

    }
}
