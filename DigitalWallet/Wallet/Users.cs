using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWallet.Wallet
{
    public class Users
    {
        public int id { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int age { get; }
        public Wallets Wallet;
        //default constructor that only create new user 
        public Users(string fname,string lname,int Age) 
        {
          if (Age < 18)
            {
                throw new ArgumentException("User must be at least 18 years old.");
            }
            this.FirstName = fname;
            this.LastName = lname;
            this.age = Age;

        }
        public void CreateWallet(decimal initialBalance)
        { 

            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative.");
            }
            Wallet = new Wallets(this,initialBalance);
        }
    }
}
