using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWallet.Wallet
{
    public class TransactionHistory
    {
        int id=0;
        string Operation;
        decimal Amount;
        DateTime dateTime;

        public TransactionHistory(string Operation, decimal amount,DateTime dateTime) 
        {
            ++id;
            this.Operation = Operation;
            this.Amount = amount;   
            dateTime = DateTime.Now;
        }
     
        public void PrintTransaction()
        {
            Console.WriteLine($"Transaction ID: {id}, Operation: {Operation}, Amount: {Amount}, Date and Time: {dateTime}");
        }
    }
}
