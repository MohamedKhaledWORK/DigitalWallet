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
        Users user;
        public void UserChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    string? fName,lName;
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
                         user = new Users(fName, lName, age);
                        Console.WriteLine("✅ User created successfully!");
                        Console.WriteLine($"Name: {user.FirstName} {user.LastName}, Age: {user.age}");
                        do
                        {
                            Console.WriteLine("Enter initial balance : ");
                            flag = decimal.TryParse(Console.ReadLine(), out initialbalance);
                        } while (!flag || initialbalance < 0);
                        user.CreateWallet(initialbalance);
                        Console.WriteLine("✅ Wallet created successfully!");
                       user.Wallet.WalletInfo();
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"❌ Failed to create user: {ex.Message}");
                    }
                        break;
                case 2:
                     user.Wallet.WalletInfo();
                    break;
                case 3:
                    do
                    {
                        Console.WriteLine("Enter Amount You Want To deposit : ");
                        flag = decimal.TryParse(Console.ReadLine(), out amount);
                    } while (!flag || amount < 0);
                    try
                    {
                        newbalance = manageWallet.Depoist(amount, user.Wallet.getbalance());
                        user.Wallet.EditBalance(newbalance);
                        Console.WriteLine("Succsseful operation");
                        Console.WriteLine($"Deposit : {amount}");
                        Console.WriteLine($"Balance : {user.Wallet.getbalance()}");
                        user.Wallet.transactionHistory.Add(new TransactionHistory("Deposit",amount,DateTime.Now));
                    }
                    catch(ArgumentException ex) 
                    {
                        Console.WriteLine($"Failed operation { ex.Message}");
                    }
                    break;
                case 4:
                    do
                    {
                        Console.WriteLine("Enter Amount You Want To Withdraw : ");
                        flag = decimal.TryParse(Console.ReadLine(), out amount);
                    } while (!flag || amount < 0);
                    try
                    {
                        newbalance = manageWallet.Wthdraw(amount, user.Wallet.getbalance());
                        user.Wallet.EditBalance(newbalance);
                        Console.WriteLine("Succsseful operation");
                        Console.WriteLine($"Withdraw : {amount}");
                        Console.WriteLine($"Balance : {user.Wallet.getbalance()}");
                        user.Wallet.transactionHistory.Add(new TransactionHistory("Withdraw", amount, DateTime.Now));

                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Failed operation {ex.Message}");
                    }
                    break;
                case 5:
                    manageWallet.TransactionHistory(user.Wallet.transactionHistory);
                    break;
            }

        }
    }
}
