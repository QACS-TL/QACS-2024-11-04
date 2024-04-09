using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; private set; }

        //public BankAccount(string accountNumber, string accountHolderName):this(accountNumber, accountHolderName, 0)
        //{

        //}

        //public BankAccount(string accountNumber, string accountHolderName, decimal balance)
        //{
        //    AccountNumber = accountNumber;
        //    AccountHolderName = accountHolderName;
        //    Balance = balance;
        //}

        //Analogous to commented code above
        public BankAccount(string accountNumber, string accountHolderName, decimal balance = 0)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;
        }

        public void WithdrawMoney (decimal amount)
        {
            if (this is not CurrentAccount && Balance - amount < 0 )
            {
                Console.WriteLine($"Failed to withdraw {amount:C} "
                                + $"from account {this.AccountNumber}. "
                                + $"Insufficient funds.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"{amount:C} successfully withdrawn from account {this.AccountNumber}");
        }
        
        public void DepositMoney(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"{amount:C} successfully deposited into account {this.AccountNumber}");
        }
    }
}