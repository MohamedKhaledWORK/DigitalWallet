# DigitalWallet
A simple C# Console Application for managing digital wallets with user accounts.

## Features
- Create new users with validation (age ≥ 18, names with letters only)
- Create wallet with initial balance
- Deposit and Withdraw money
- View wallet balance
- Transaction history logging
- Auto-incrementing IDs for users and transactions
- Proper error handling and input validation

## Technologies
- **C#** & **.NET 9.0**
- Console Application
- Object-Oriented Programming (OOP)
- Exception Handling

## Project Structure
DigitalWallet/
├── DigitalWallet.sln
├── DigitalWallet/
│   ├── Program.cs
│   ├── ProgramSystem/
│   │   ├── CreateUser.cs
│   │   ├── CreateWallet.cs
│   │   ├── HandleUserInput.cs
│   │   ├── ManageWallet.cs
│   │   └── ProgramMenu.cs
│   └── Wallet/
│       ├── Users.cs
│       ├── Wallets.cs
│       └── TransactionHistory.cs
└── README.md

## How to Run
1. Clone or download the project
2. Open the solution in Visual Studio 2022
3. Build the project:
   dotnet build
4. Run the application:
   dotnet run
  
## How to Use
1. Choose option `1` → Create Wallet
2. Enter First Name, Last Name, and Age
3. Enter initial balance
4. Use other options to:
   - View balance
   - Deposit money
   - Withdraw money
   - View transaction history

## Sample Output
Welcome to the Digital Wallet!
1. Create Wallet
Enter your choice : 1
Creating Wallet
First Name: Ahmed
Last Name: Mohammed
Your Age: 25
✅ User created successfully!
Enter initial balance : 500
✅ Wallet created successfully!

## Future Enhancements
- Save data persistently (JSON / SQLite)
- Multiple wallets per user
- User login system
- Better UI using Spectre.Console library
- Unit tests

## Author
Mohamed Khaled 
Created: July 2026
