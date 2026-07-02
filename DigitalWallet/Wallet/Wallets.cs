using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWallet.Wallet
{
    public class Wallets
    {
        Users user;
        private decimal balance;
        public List<TransactionHistory> transactionHistory;
        public Wallets(Users user,decimal initialBalance)
        {
            this.user = user;
            balance = initialBalance;
            transactionHistory = new List<TransactionHistory>();
        }

        public void WalletInfo()
        {
            Console.WriteLine($"User: {user.FirstName} {user.LastName}, Balance: {balance}");
        }
        public decimal getbalance()
        {
            return balance;
        }
        public void EditBalance (decimal amount)
        {
            balance = amount;
            Console.WriteLine("Balance Updated"); 
       }
    }
}
