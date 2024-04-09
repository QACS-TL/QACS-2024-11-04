using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    public class ISAAccount : SavingsAccount
    {
        private decimal ISALimit = 20000.00M;
        //public ISAAccount(string accountNumber, string accountHolderName) : this(accountNumber, accountHolderName, 0)
        //{
        //}

        //public ISAAccount(string accountNumber, string accountHolderName, decimal balance): base(accountNumber, accountHolderName, balance)
        //{
        //}

        //Analogous to commented code above
        public ISAAccount(string accountNumber, string accountHolderName, decimal balance = 0) : base(accountNumber, accountHolderName, balance)
        {
        }

        public void DepositMoney(decimal amount)
        {
            if((Balance + amount) > ISALimit)
            {
                Console.WriteLine($"Failed to deposit £{amount} into account {this.AccountNumber}. ISA limit reached.");
                return;
            }
            base.DepositMoney(amount);
            Console.WriteLine($"{amount:C} successfully deposited into account {this.AccountNumber}");
        }
    }
}
