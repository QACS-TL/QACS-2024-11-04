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

        public CurrentAccount(
            string accountNumber, 
            string accountHolderName, 
            decimal balance = 0, 
            decimal overdraftLimit = 0
            ) : base(accountNumber, accountHolderName, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void WithdrawMoney(decimal amount)
        {
            if (Balance - amount < (0 - OverdraftLimit))
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
