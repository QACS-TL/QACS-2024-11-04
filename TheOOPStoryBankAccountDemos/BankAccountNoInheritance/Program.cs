using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Current Accounts can have an overdraft limit, Savings accounts cannot

            //Create new savings account with initial balance of £200.00 and attempt to withdraw £150.00
            BankAccount account1 = new BankAccount { 
                AccountNumber = "12345678",
                AccountHolderName = "Busby Berkeley", 
                Balance = 200.00M, 
                AccountType = "Savings" };
            Console.WriteLine($"{account1.AccountHolderName}'s starting balance is:{account1.Balance:C}");
            //inital account, funds deposited and withdrawn
            account1.WithdrawMoney(150.00m);
            Console.WriteLine($"Account Balance:{account1.Balance:C}");

            //create new current account with initial balance of £200.00 and attempt to withdraw amount within overdraft limit of £100.00
            BankAccount account2 = new BankAccount {
                AccountNumber = "98765432",
                AccountHolderName = "Ginger Rogers",
                Balance = 200.00m,
                AccountType = "Current", 
                OverdraftLimit = 100.00M };
            Console.WriteLine($"{account2.AccountHolderName}'s starting balance is:{account2.Balance:C} and their overdraft limit is {account2.OverdraftLimit:C}");
            // Can change balance indirectly via WithdrawMoney method
            account2.WithdrawMoney(250.00m); //This withdrawal will succeed because overdraft limit is not exceeded
            Console.WriteLine($"Account Balance:{account2.Balance:C}");

            //create new current account with initial balance of £200.00 and attempt to exceed £100.00 overdraft limit
            BankAccount account3 = new BankAccount{
                AccountNumber = "12121212",
                AccountHolderName = "Fred Astaire",
                Balance = 100.00m,
                AccountType = "Current",
                OverdraftLimit = 100.00M };
            Console.WriteLine($"{account3.AccountHolderName}'s starting balance is:{account3.Balance:C} and their overdraft limit is {account2.OverdraftLimit:C}");
            // Can change balance indirectly via WithdrawMoney method
            account3.WithdrawMoney(250.00m); //This withdrawal will NOT succeed because overdraft limit would be exceeded
            Console.WriteLine($"Account Balance:{account3.Balance:C}");
            Console.WriteLine();
        }
    }
}
