using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankAccountsAbstract
{
    public class CurrentAccount: BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        public CurrentAccount(string accountNumber, string accountHolderName) : this(accountNumber, accountHolderName, 0)
        {

        }

        public CurrentAccount(string accountNumber, string accountHolderName, decimal balance) : this(accountNumber, accountHolderName, balance, 0)
        {

        }

        public CurrentAccount(string accountNumber, string accountHolderName, decimal balance, decimal overdraftLimit): base(accountNumber, accountHolderName, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void WithdrawMoney(decimal amount)
        {
            if(Balance - amount < (0 - OverdraftLimit))
            {
                Console.WriteLine($"Failed to withdraw {amount:C} from account {this.AccountNumber}. Overdraft limit would be exceeded.");
                return;
            }
            base.WithdrawMoney(amount);
        }

        public override void DepositMoney(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
    
}
