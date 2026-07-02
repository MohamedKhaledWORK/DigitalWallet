using DigitalWallet.ProgramSystem;

namespace DigitalWallet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProgramMenu menu = new ProgramMenu();
            HandleUserInput handleUserInput = new HandleUserInput();
            bool flag;
            int choice;
            while (true) 
            {
             menu.DisplayMenu();
                do
                {
                    Console.Write("Enter your choice : ");
                    flag = int.TryParse(Console.ReadLine(), out choice);
                } while (!flag || choice < 1 || choice > 6);
               
                if (choice == 6)
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                }
                handleUserInput.UserChoice(choice);

            }
        }
    }
}
