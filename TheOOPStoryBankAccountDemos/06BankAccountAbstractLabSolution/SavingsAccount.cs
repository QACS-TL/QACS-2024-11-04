using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsAbstract
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }
        public SavingsAccount(string accountNumber, string accountHolderName) : this(accountNumber, accountHolderName, 0)
        {
        }

        public SavingsAccount(string accountNumber, string accountHolderName, decimal balance): this(accountNumber, accountHolderName, balance, 0.5M)
        {
        }

        public SavingsAccount(string accountNumber, string accountHolderName, decimal balance, decimal interestRate) : base(accountNumber, accountHolderName, balance)
        {
            InterestRate = interestRate;
        }

        public void AddInterest()
        {
            base.DepositMoney(Balance * InterestRate / 100);
            Console.WriteLine($"Interest at {InterestRate}% added to {this.AccountNumber} new balance is {Balance:C}.");
        }
    }
}
