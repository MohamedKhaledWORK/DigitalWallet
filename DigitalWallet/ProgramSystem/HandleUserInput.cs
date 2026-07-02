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
        public void UserChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    string? fName,lName;
                    bool flag;
                    int age, initialbalance;
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
                        Users user = new Users(fName, lName, age);
                        Console.WriteLine("✅ User created successfully!");
                        Console.WriteLine($"Name: {user.FirstName} {user.LastName}, Age: {user.age}");
                        do
                        {
                            Console.WriteLine("Enter initial balance : ");
                            flag = int.TryParse(Console.ReadLine(), out initialbalance);
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
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }

        }

        //public void HandleInput(int choice, decimal amount, decimal Totalbalance, List<TransactionHistory> transactionHistories)
        //{
        //    ManageWallet manageWallet = new ManageWallet();
        //    switch (choice)
        //    {
        //        case 1:
        //            Console.WriteLine("Enter initial balance:");
        //            decimal initialBalance = Convert.ToDecimal(Console.ReadLine());
        //            Totalbalance = initialBalance;
        //            Console.WriteLine($"Wallet created with initial balance: {Totalbalance}");
        //            break;
        //        case 2:
        //            Console.WriteLine($"Current balance: {Totalbalance}");
        //            break;
        //        case 3:
        //            Console.WriteLine("Enter amount to deposit:");
        //            amount = Convert.ToDecimal(Console.ReadLine());
        //            Totalbalance = manageWallet.Depoist(amount, Totalbalance);
        //            transactionHistories.Add(new TransactionHistory(Totalbalance));
        //            transactionHistories.Last().AddTransaction("Deposit", amount);
        //            Console.WriteLine($"Deposited: {amount}, New balance: {Totalbalance}");
        //            break;
        //        case 4:
        //            Console.WriteLine("Enter amount to withdraw:");
        //            amount = Convert.ToDecimal(Console.ReadLine());
        //            Totalbalance = manageWallet.Wthdraw(amount, Totalbalance);
        //            transactionHistories.Add(new TransactionHistory(Totalbalance));
        //            transactionHistories.Last().AddTransaction("Withdraw", amount);
        //            Console.WriteLine($"Withdrew: {amount}, New balance: {Totalbalance}");
        //            break;
        //        case 5:
        //            manageWallet.TransactionHistory(transactionHistories);
        //            break;
        //        case 6:
        //            Console.WriteLine("Exiting...");
        //            break;
        //        default:
        //            Console.WriteLine("Invalid choice. Please try again.");
        //            break;
        //    }
    }
}
