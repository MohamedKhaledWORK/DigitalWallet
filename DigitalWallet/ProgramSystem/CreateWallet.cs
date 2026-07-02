using DigitalWallet.Wallet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWallet.ProgramSystem
{
    public static  class CreateWallet
    {
        public static void CreateNewWallet(Users user,decimal initialbalance) 
        {
             user.CreateWallet(initialbalance);
        }
    }
}
