using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWallet.Wallet
{
    public class Users
    {
        public int id;
        string FirstName ;
        string LastName ;
        int age;
        Wallet Wallet;
        //default constructor that only create new user 
        public Users(string fname,string lname,int age) 
        {
          if (age < 18)
            {
                throw new ArgumentException("User must be at least 18 years old.");
            }
            this.FirstName = fname;
            this.LastName = lname;
            this.age = age;
        }
        public void CreateWallet(decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative.");
            }
            Wallet = new Wallet(initialBalance);
        }
    }
}
