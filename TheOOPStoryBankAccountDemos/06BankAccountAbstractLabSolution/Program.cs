using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Now does not work because BankAccount class is abstract            
            //BankAccount account1 = new BankAccount("12345678", "Busby Berkeley");
            ////inital account, funds deposited and withdrawn
            //account1.DepositMoney(100.80m);
            //account1.WithdrawMoney(60.80m);
            //Console.WriteLine($"Account Balance:{account1.Balance:C}");

            ////create new account using constructor, funds deposited and attempt to withdraw too much
            //BankAccount account2 = new BankAccount("98765432", "Ginger Rogers", 200.00m);
            //account2.DepositMoney(100.80m);
            //account2.WithdrawMoney(360.80m);
            //Console.WriteLine($"Account Balance:{account2.Balance:C}");

            //Current account with £100 Overdaft
            CurrentAccount currentAccount1 = new CurrentAccount("98787676", "Donald O'Connor");
            currentAccount1.OverdraftLimit = 100;
            //Withdrawing a value that takes the balance below 0 but above overdraft limit
            currentAccount1.WithdrawMoney(50);
            //Withdrawing a value that takes the balance above overdraft limit
            currentAccount1.WithdrawMoney(51);
            Console.WriteLine($"Current Account Balance:{currentAccount1.Balance:C}");

            //Create new current acccount using constructor
            CurrentAccount currentAccount2 = new CurrentAccount("98765432", "Fred Astaire", 200.00m, 100.00m);
            //Withdrawing a value that takes the balance below 0 but above overdraft limit
            currentAccount2.WithdrawMoney(150.00m);
            //Withdrawing a value that takes the balance above overdraft limit
            currentAccount2.WithdrawMoney(51.00m);
            Console.WriteLine($"Current Account Balance:{currentAccount2.Balance:C}");

            //look at a newly created CurrentAccount object as a simple BankAccount
            BankAccount bankAccount = new CurrentAccount("87654321", "Cyd Charisse", 100.00m, 100.00m);
            //Withdrawing a value that takes the balance below 0 but above overdraft limit
            bankAccount.WithdrawMoney(150.00m);
            Console.WriteLine($"Current Account Balance:{bankAccount.Balance:C}");


            //Savings account with no overdraft and add interest
            SavingsAccount savingsAccount1 = new SavingsAccount("12121212", "Gene Kelly", 50.00M, 5);
            //withdrawing any value with no other depoists will fail
            savingsAccount1.DepositMoney(50.00m);
            savingsAccount1.AddInterest();
            Console.WriteLine($"Savings Account Balance:{savingsAccount1.Balance:C}");

            //Create new savings acccount using constructor and attempting to withdraw too much
            SavingsAccount savingsAccount2 = new SavingsAccount("23434545", "Debbie Reynolds", 150m);
            savingsAccount2.WithdrawMoney(120.00m);
            //withdrawing any value with no other deposits will fail
            savingsAccount2.WithdrawMoney(50.00m);
            Console.WriteLine($"Savings Account Balance:{savingsAccount2.Balance:C}");

            //ISA account with no overdraft
            ISAAccount isaAccount1 = new ISAAccount("56745654", "Jean Hagen");
            //withdrawing any value with no other deposits will fail
            isaAccount1.WithdrawMoney(50.00m);
            isaAccount1.AddInterest();
            Console.WriteLine($"ISA Account Balance:{isaAccount1.Balance:C}");

            //Create new ISA acccount using constructor and trying to deposit too much
            ISAAccount isaAccount2 = new ISAAccount("76757473", "Frank Sinatra", 15000.00m);
            isaAccount2.DepositMoney(5000.01m);
            Console.WriteLine($"ISA Account Balance:{isaAccount2.Balance:C}");

            //Fixed Term Savings Account
            DateTime openingDate = new DateTime(DateTime.Now.Ticks);
            DateTime maturityDate = openingDate.AddYears(1);
            FixedTermSavingsAccount fixedTermAccount1 = new FixedTermSavingsAccount("81818181", "Bing Crosby", 1000.00M, openingDate, maturityDate);
            fixedTermAccount1.DepositMoney(50.00m);
            Console.WriteLine($"Fixed Term Account Balance:{fixedTermAccount1.Balance:C}");

            //Fixed Term Savings Account Deposit Window exceeded
            openingDate = new DateTime(DateTime.Now.Ticks).AddDays(-7);
            maturityDate = openingDate.AddYears(1);
            FixedTermSavingsAccount fixedTermAccount2 = new FixedTermSavingsAccount("98979695", "Grace Kelly", 15000.00m, openingDate, maturityDate);
            fixedTermAccount2.DepositMoney(4000.00m);
            Console.WriteLine($"Fixed Term Account Balance:{fixedTermAccount2.Balance:C}");

            //Fixed Term Savings Account Attempt to withdraw too early
            openingDate = new DateTime(DateTime.Now.Ticks).AddDays(-364);
            maturityDate = openingDate.AddYears(1);
            FixedTermSavingsAccount fixedTermAccount3 = new FixedTermSavingsAccount("98979695", "Grace Kelly", 15000.00m, openingDate, maturityDate);
            fixedTermAccount3.WithdrawMoney(5000.00m);
            Console.WriteLine($"Fixed Term Account Balance:{fixedTermAccount3.Balance:C}");

            //Fixed Term Savings Account Attempt to withdraw post maturity date
            openingDate = new DateTime(DateTime.Now.Ticks).AddDays(-365);
            maturityDate = openingDate.AddYears(1);
            FixedTermSavingsAccount fixedTermAccount4 = new FixedTermSavingsAccount("98979695", "Grace Kelly", 15000.00m, openingDate, maturityDate);
            fixedTermAccount4.WithdrawMoney(5000.00m);
            Console.WriteLine($"Fixed Term Account Balance:{fixedTermAccount4.Balance:C}");

            List<BankAccount> accounts = new List<BankAccount>();
            //accounts.Add(account1);
            //accounts.Add(account2);
            accounts.Add(currentAccount1);
            accounts.Add(currentAccount2);
            accounts.Add(savingsAccount1);
            accounts.Add(savingsAccount2);
            accounts.Add(isaAccount1);
            accounts.Add(isaAccount2);
            accounts.Add(fixedTermAccount1);
            accounts.Add(fixedTermAccount2);
            accounts.Add(fixedTermAccount3);
            accounts.Add(fixedTermAccount4);

            decimal totalFundsInBank = 0;
            foreach(BankAccount account in accounts)
            {
                totalFundsInBank += account.Balance;
            }
            Console.WriteLine($"Using trad foreach loop. Total amount of money stored in bank is {totalFundsInBank:C}");

            //Not quite right. Using LINQ (and a bit of Lambda)
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
