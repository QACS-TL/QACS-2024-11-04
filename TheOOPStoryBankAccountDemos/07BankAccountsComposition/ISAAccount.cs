using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsComposition
{
    public class ISAAccount : SavingsAccount
    {
        private decimal ISALimit = 20000.00M;

        public ISAAccount(
            string accountNumber,
            string accountHolderName,
            decimal balance = 0,
            decimal interestRate = 5.0M
            ) : base(accountNumber, accountHolderName, balance, interestRate)
        {
        }

        public override void DepositMoney(decimal amount)
        {
            if ((Balance + amount) > ISALimit)
            {
                Console.WriteLine(
                      $"Failed to deposit £{amount} into "
                    + $"account {this.AccountNumber}. ISA limit reached.");
                return;
            }
            base.DepositMoney(amount);
        }
    }
}
