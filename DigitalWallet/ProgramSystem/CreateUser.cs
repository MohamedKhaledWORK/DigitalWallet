using DigitalWallet.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWallet.ProgramSystem
{
    public static class CreateUser
    {
        public static Users CreateNewUser(string firstName, string lastName, int Age)
        {

            return new Users(firstName, lastName , Age);
        }
       
    }
}
