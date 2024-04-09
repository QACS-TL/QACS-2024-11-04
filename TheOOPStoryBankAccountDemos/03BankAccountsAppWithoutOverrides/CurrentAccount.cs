using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankAccountsApp
{
    public class CurrentAccount: BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        //public CurrentAccount(string accountNumber, string accountHolderName) : this(accountNumber, accountHolderName, 0)
        //{

        //}

        //public CurrentAccount(string accountNumber, string accountHolderName, decimal balance) : this(accountNumber, accountHolderName, balance, 0)
        //{

        //}

        //public CurrentAccount(string accountNumber, string accountHolderName, decimal balance, decimal overdraftLimit): base(accountNumber, accountHolderName, balance)
        //{
        //    OverdraftLimit = overdraftLimit;
        //}

        //Analogous to commented code above
        public CurrentAccount(
            string accountNumber, 
            string accountHolderName, 
            decimal balance = 0, 
            decimal overdraftLimit = 0
            ) : base(accountNumber, accountHolderName, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public void WithdrawMoney(decimal amount)
        {
            if(Balance - amount < (0 - OverdraftLimit))
            {
                Console.WriteLine(
                    $"Failed to withdraw {amount:C} from "
                  + $"account {this.AccountNumber}. "
                  + $"Overdraft limit would be exceeded.");
                return;
            }
            base.WithdrawMoney(amount);
        }
    }
}
