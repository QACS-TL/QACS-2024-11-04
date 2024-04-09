using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsComposition
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

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
            base.DepositMoney(Balance * InterestRate / 100);
            Console.WriteLine(
                $"Interest at {InterestRate}% added to "
              + $"{this.AccountNumber} new balance is {Balance:C}.");
        }
    }
}
