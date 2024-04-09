using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsInterfaces
{
    class FixedTermSavingsAccount:SavingsAccount
    {
        public DateTime MaturityDate { get; set; }
        public DateTime OpeningDate { get; set; }

        public FixedTermSavingsAccount(string accountNumber, string accountHolderName) : this(accountNumber, accountHolderName, 0)
        {
        }
        
        public FixedTermSavingsAccount(string accountNumber, string accountHolderName, decimal balance) : this(accountNumber, accountHolderName, balance, new DateTime(DateTime.Now.Ticks), new DateTime(DateTime.Now.Ticks).AddYears(1))
        {
        }

        public FixedTermSavingsAccount(string accountNumber, string accountHolderName, decimal balance, DateTime openingDate, DateTime maturityDate) : base(accountNumber, accountHolderName, balance)
        {
            OpeningDate = openingDate;
            MaturityDate = maturityDate;
        }

        public override void WithdrawMoney(decimal amount)
        {
            if (DateTime.Now < MaturityDate)
            {
                Console.WriteLine($"Failed to withdraw {amount:C} from account {this.AccountNumber}. Funds cannot be released until {MaturityDate.ToShortDateString()}.");
                return;
            }
            base.WithdrawMoney(amount);
        }

        public override void DepositMoney(decimal amount)
        {
            if (DateTime.Now > OpeningDate.AddDays(7))
            {
                Console.WriteLine($"Failed to deposit {amount:C} into account {this.AccountNumber}. Deposit Window ({OpeningDate.AddDays(7).ToShortDateString()}) exceeded.");
                return;
            }
            base.DepositMoney(amount);
        }
    }
}
