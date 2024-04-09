using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsAbstract
{
    public class ISAAccount : SavingsAccount
    {
        private decimal ISALimit = 20000.00M;
        public ISAAccount(string accountNumber, string accountHolderName) : this(accountNumber, accountHolderName, 0)
        {
        }

        public ISAAccount(string accountNumber, string accountHolderName, decimal balance): base(accountNumber, accountHolderName, balance)
        {
        }

        public virtual void DepositMoney(decimal amount)
        {
            if((Balance + amount) > ISALimit)
            {
                Console.WriteLine($"Failed to deposit £{amount} into account {this.AccountNumber}. ISA limit reached.");
                return;
            }
            base.DepositMoney(amount);
        }
    }
}
