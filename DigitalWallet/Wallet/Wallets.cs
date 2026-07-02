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
        public decimal Balance()
        {
            return balance;
        }
        public void Depoist(decimal amount)
        {
            if (amount < 0) { throw new ArgumentException("CanNot Deposit Amount < 0"); }
            balance += amount;
        }
        public void Wthdraw(decimal amount)
        {
            if (balance < amount) { throw new ArgumentException("Not enough balance in your Wallet"); }
            if (amount < 0) { throw new ArgumentException("Cant Withdraw Negative Amount"); }
            balance -= amount;
        }
    }
}
