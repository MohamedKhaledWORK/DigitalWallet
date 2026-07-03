using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWallet.Wallet
{
    public class Wallet
    {
        User user;
        private decimal balance;
        public List<TransactionHistory> transactionHistory { get; set; }
        public Wallet(User user,decimal initialBalance)
        {
            this.user = user;
            balance = initialBalance;
            transactionHistory = new List<TransactionHistory>();
        }

        
        public decimal Balance()
        {
            return balance;
        }
        public void Deposit(decimal amount)
        {
            if (amount < 0) { throw new ArgumentException("CanNot Deposit Amount < 0"); }
            balance += amount;
            user.Wallet.transactionHistory.Add(new TransactionHistory("Deposit", amount, DateTime.Now));

        }
        public void Withdraw(decimal amount)
        {
            if (balance < amount) { throw new ArgumentException("Not enough balance in your Wallet"); }
            if (amount < 0) { throw new ArgumentException("Cant Withdraw Negative Amount"); }
            balance -= amount;
            user.Wallet.transactionHistory.Add(new TransactionHistory("Withdraw", amount, DateTime.Now));

        }
        public override string ToString()
        {
            return $"User: {user.FirstName} {user.LastName}, Balance: {balance}";
        }
    }
}
