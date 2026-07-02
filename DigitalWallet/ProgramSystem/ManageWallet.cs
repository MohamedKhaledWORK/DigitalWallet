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
       
        public void TransactionHistory(List<TransactionHistory> transactionHistories) 
        {
            foreach (var transaction in transactionHistories)
            {
                transaction.PrintTransaction();
            }
        }

    }
}
