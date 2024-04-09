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
        public decimal Balance { get; set; } //Note public set clause
        public string AccountType { get; set; } = "Current";
        public decimal OverdraftLimit { get; set; } = 0.00M;

        public BankAccount()
        {

        }

        public BankAccount(string accountNumber, string accountHolderName, decimal balance = 0.00M, string accountType = "Current", decimal overdraftLimit = 0.00M)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;
            AccountType = accountType;
            OverdraftLimit = overdraftLimit;
        }

        public void WithdrawMoney (decimal amount)
        {
            if (AccountType == "Savings")
            {
                if (Balance - amount < 0)
                {
                    Console.WriteLine($"Failed to withdraw {amount:C} from account {this.AccountNumber}. Insufficient funds.");
                    return;
                }
            }
            else if (AccountType == "Current")
            {
                if (Balance - amount < -OverdraftLimit)
                {
                    Console.WriteLine($"Failed to withdraw {amount:C} from account {this.AccountNumber}. Overdraft limit would be exceeded.");
                    return;
                }
            }
            else
            {
                Console.WriteLine($"{AccountType} is an invalid Bank Account Type! Withdrawal rejected");
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