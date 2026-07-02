using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWallet.ProgramSystem
{
    public class ProgramMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to the Digital Wallet!");
            Console.WriteLine("1. Create Wallet");
            Console.WriteLine("2. View Wallet Balance");
            Console.WriteLine("3. Add Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. View Transaction History");
            Console.WriteLine("6. Exit");
        }
    
    }
}
