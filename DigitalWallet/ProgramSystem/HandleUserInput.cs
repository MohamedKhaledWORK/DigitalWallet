using DigitalWallet.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalWallet.ProgramSystem
{
    public class HandleUserInput
    {
        ManageWallet manageWallet = new ManageWallet();
        bool flag;
        User user;
        public void UserChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    #region Create User Wallet
                    string? fName, lName;
                    bool flag;
                    int age;
                    decimal amount, newbalance, initialbalance;
                    Console.WriteLine("Creating Wallet");
                    Console.WriteLine("Please Enter the following Data in Order");
                    do
                    {
                        Console.WriteLine("First Name:");
                        fName = Console.ReadLine()?.Trim();
                    } while (string.IsNullOrWhiteSpace(fName) || !fName.All(char.IsLetter));

                    do
                    {
                        Console.WriteLine("Last Name:");
                        lName = Console.ReadLine()?.Trim();
                    } while (string.IsNullOrWhiteSpace(lName) || !lName.All(char.IsLetter));

                    do
                    {
                        Console.WriteLine("Your Age:");
                        flag = int.TryParse(Console.ReadLine(), out age);
                    } while (!flag || age < 0);
                    try
                    {
                        user = CreateUser.CreateNewUser(fName, lName, age);
                        Console.WriteLine("✅ User created successfully!");
                       user.ToString();
                        do
                        {
                            Console.WriteLine("Enter initial balance : ");
                            flag = decimal.TryParse(Console.ReadLine(), out initialbalance);
                        } while (!flag || initialbalance < 0);
                        CreateWallet.CreateNewWallet(user,initialbalance);
                        Console.WriteLine("✅ Wallet created successfully!");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"❌ Failed to create user: {ex.Message}");
                    } 
                    #endregion
                    break;
                case 2:
                    #region Show Wallet Info
                    if (user == null) { Console.WriteLine("User doesn't exist "); break; }

                    Console.WriteLine(user.Wallet.ToString());  
                    #endregion
                    break;
                case 3:
                    #region Deposit
                    do
                    {
                        Console.WriteLine("Enter Amount You Want To deposit : ");
                        flag = decimal.TryParse(Console.ReadLine(), out amount);
                    } while (!flag || amount < 0);
                    try
                    {
                        if (user == null) { Console.WriteLine("User doesn't exist "); break; }
                        user.Wallet.Deposit(amount);
                        Console.WriteLine("Succsseful operation");
                        Console.WriteLine($"Deposit : {amount}");
                        Console.WriteLine($"Balance : {user.Wallet.Balance()}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Failed operation {ex.Message}");
                    }
                    break; 
                #endregion
                case 4:
                    #region Withdraw
                    do
                    {
                        Console.WriteLine("Enter Amount You Want To Withdraw : ");
                        flag = decimal.TryParse(Console.ReadLine(), out amount);
                    } while (!flag || amount < 0);
                    try
                    {

                        if (user == null) { Console.WriteLine("User doesn't exist "); break; }
                        user.Wallet.Withdraw(amount);
                        Console.WriteLine("Succsseful operation");
                        Console.WriteLine($"Withdraw : {amount}");
                        Console.WriteLine($"Balance : {user.Wallet.Balance()}");

                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Failed operation {ex.Message}");
                    } 
                    #endregion
                    break;
                case 5:
                    #region Transaction Info

                    if (user == null) { Console.WriteLine("User doesn't exist "); break; }
                    manageWallet.TransactionHistory(user.Wallet.transactionHistory); 
                    #endregion
                    break;
            }

        }
    }
}
