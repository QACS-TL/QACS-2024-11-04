using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BankAccount account1 = new BankAccount(
                                         "12345678", 
                                         "Busby Berkeley");
            //inital account, funds deposited and withdrawn
            account1.DepositMoney(100.80m);
            account1.WithdrawMoney(60.80m);
            account1.WithdrawMoney(20.00m, 5.00m);
            Console.WriteLine($"Account Name: {account1.AccountHolderName}, "
                            + $"Balance:{account1.Balance:C}");

            //create new account using constructor,
            //funds deposited and attempt to withdraw too much
            BankAccount account2 = new BankAccount(
                                          "98765432", 
                                          "Ginger Rogers", 
                                          200.00m);
            account2.DepositMoney(100.80m);
            account2.WithdrawMoney(360.80m); //Withdrawal will fail due to lack of funds
            //account2.Balance -= 360.80m; //But this withdrawal will succeed!
            Console.WriteLine($"Account Name: {account2.AccountHolderName}, "
                            + $"Balance:{account2.Balance:C}");

            //Note how client logic can directly change the balance. This is dangerous
            //account2.Balance = 100000000.00M;

            List<BankAccount> accounts = new List<BankAccount>();
            accounts.Add(account1);
            accounts.Add(account2);

            decimal totalFundsInBank = 0;
            foreach(BankAccount account in accounts)
            {
                totalFundsInBank += account.Balance;
            }
            Console.WriteLine($"Using trad foreach loop. Total amount of money stored in bank is {totalFundsInBank:C}");

            //Not quite right. Using LINQ (muddling query and method notation)
            var totalFunds = (from account in accounts
                              select new { totalFunds = accounts.Sum(a => a.Balance) }
                              ).ToList();

            //Will print 8 lines, one for each account even though the value printed is the total of ALL account balances
            totalFunds.ForEach(item => Console.WriteLine($"Using LINQ multiple results. Total amount of money stored in bank is {item.totalFunds:C}"));

            //Better using LINQ (and a bit of Lambda)
            totalFundsInBank = (from account in accounts
                                select account.Balance).Sum();
            //Will print 8 lines, one for each account even though the value printed is the total of ALL account balances
            Console.WriteLine($"Using LINQ single result. Total amount of money stored in bank is {totalFundsInBank:C}");


            //Using Lambda
            totalFundsInBank = accounts.Sum(a => a.Balance);
            Console.WriteLine($"Using Lambda. Total amount of money stored in bank is {totalFundsInBank:C}");

            Console.ReadLine();
        }
    }
}
