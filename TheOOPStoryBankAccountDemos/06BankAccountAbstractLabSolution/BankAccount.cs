using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsAbstract
{
    public abstract class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountNumber, string accountHolderName):this(accountNumber, accountHolderName, 0)
        {

        }

        public BankAccount(string accountNumber, string accountHolderName, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = balance;
        }

        public virtual void WithdrawMoney (decimal amount)
        {
            if (Balance - amount < 0 )
            {
                Console.WriteLine($"Failed to withdraw {amount:C} from account {this.AccountNumber}. Insufficient funds.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"{amount:C} successfully withdrawn from account {this.AccountNumber}");
        }

        public virtual void DepositMoney(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"{amount:C} successfully deposited into account {this.AccountNumber}");
        }




}
}