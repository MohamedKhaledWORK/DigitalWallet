using DigitalWallet.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWallet.ProgramSystem
{
    public class ManageWallet
    {
        public decimal Depoist(decimal amount,decimal Totalbalance) 
        {
            if (amount < 0) { throw new ArgumentException("CanNot Deposit Amount < 0"); }
            Totalbalance += amount;
            return Totalbalance;
        }
        public decimal Wthdraw(decimal amount, decimal Totalbalance) {
            if (Totalbalance < amount) { throw new ArgumentException("Not enough balance in your Wallet"); }
            if (amount < 0 ) { throw new ArgumentException("Cant Withdraw Negative Amount"); }
            Totalbalance -= amount;
            return Totalbalance;
        }
        public void TransactionHistory(List<TransactionHistory> transactionHistories) 
        {
            foreach (var transaction in transactionHistories)
            {
                transaction.PrintTransaction();
            }
        }

    }
}
