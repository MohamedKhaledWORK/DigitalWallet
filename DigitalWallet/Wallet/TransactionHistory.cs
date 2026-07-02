using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWallet.Wallet
{
    public class TransactionHistory
    {
        private static int _nextId = 1;     // Static counter
        int id;
        string Operation;
        decimal Amount;
        DateTime dateTime;

        public TransactionHistory(string Operation, decimal amount,DateTime dateTime) 
        {
            id= _nextId++; // Assign current value and increment for next transaction
            this.Operation = Operation;
            this.Amount = amount;   
            this.dateTime = dateTime;
        }
     
        public void PrintTransaction()
        {
            Console.WriteLine($"Transaction ID: {id}, Operation: {Operation}, Amount: {Amount}, Date and Time: {dateTime}");
        }
    }
}
