using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }
        //public SavingsAccount(string accountNumber, string accountHolderName) : this(accountNumber, accountHolderName, 0)
        //{
        //}

        //public SavingsAccount(string accountNumber, string accountHolderName, decimal balance): this(accountNumber, accountHolderName, balance, 0.5M)
        //{
        //}

        //public SavingsAccount(string accountNumber, string accountHolderName, decimal balance, decimal interestRate) : base(accountNumber, accountHolderName, balance)
        //{
        //    InterestRate = interestRate;
        //}

        //Analogous to commented code above
        public SavingsAccount(
                string accountNumber, 
                string accountHolderName, 
                decimal balance = 0, 
                decimal interestRate = 0.5M
        ) : base(accountNumber, accountHolderName, balance)
        {
            InterestRate = interestRate;
        }

        public void AddInterest()
        {
            base.DepositMoney(this.Balance * InterestRate / 100);
            Console.WriteLine(
                $"Interest at {InterestRate}% "
              + $"added to {this.AccountNumber} "
              + $"new balance is {Balance:C}.");
        }
    }
}
