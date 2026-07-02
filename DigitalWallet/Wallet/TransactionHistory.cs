using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWallet.Wallet
{
    public class TransactionHistory
    {
        int id;
        string Operation;
        decimal Amount;
        DateTime dateTime;

        public TransactionHistory(decimal initialBalance) 
        {
         
        }
        public void AddTransaction(string operation, decimal amount)
        {
            id++;
            Operation = operation;
            Amount = amount;
            dateTime = DateTime.Now;
        }
        public void PrintTransaction()
        {
            Console.WriteLine($"Transaction ID: {id}, Operation: {Operation}, Amount: {Amount}, Date and Time: {dateTime}");
        }
    }
}
