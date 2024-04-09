using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
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

            //VIP Bank Account (wraps TravelInsurance objects)
            Console.WriteLine("\n************************\n");
            VIPBankAccount vipAccount = new VIPBankAccount("11111111", "Celeste Holm", 5000.00M);
            vipAccount.WithdrawMoney(150.00m);
            vipAccount.DepositMoney(51.00m);
            Console.WriteLine($"Current Account Balance:{vipAccount.Balance:C}");
            //Using wrapped insurance object's properties and methods
            Console.WriteLine($"Bank account {vipAccount.AccountNumber}'s travel insurance details are "
                + $"policy number: {vipAccount.TravelInsurancePolicyNumber} "
                + $"premium:  {vipAccount.TravelInsurancePremium} "
                + $"excess:  {vipAccount.TravelInsuranceExcess} ");
            vipAccount.StartTravelInsuranceClaim();
            //Using exposed insurance object's properties and methods
            IInsurance travelInsurance = vipAccount.TravelInsurancePolicy;
            Console.WriteLine($"Bank account {vipAccount.AccountNumber}'s travel insurance details are "
                + $"policy number: {travelInsurance.PolicyNumber} "
                + $"premium:  {travelInsurance.Premium} "
                + $"excess:  {travelInsurance.Excess} ");
            //Note need to cast insurance object to specialised type
            ((TravelInsurance)travelInsurance).StartClaim();

            //VVIP Bank Account (implements IInsurance)
            Console.WriteLine("\n************************\n");
            VVIPBankAccount vvipAccount = new VVIPBankAccount(
                "22222222", 
                "Cyd Charrisse", 
                2500.00M,
                1.5m);
            vvipAccount.WithdrawMoney(250.00m);
            vvipAccount.DepositMoney(50.00m);
            Console.WriteLine($"Current Account Balance:{vvipAccount.Balance:C}");
            //Using wrapped insurance object's properties and methods
            Console.WriteLine(
                  $"Bank account {vvipAccount.AccountNumber}'s "
                + $"travel insurance details are "
                + $"policy number: {vvipAccount.PolicyNumber} "
                + $"premium:  {vvipAccount.Premium} "
                + $"excess:  {vvipAccount.Excess} ");
            vvipAccount.StartClaim();

            //Actual TavelInsurance object
            TravelInsurance tInsurance1 = new TravelInsurance(
                "77777777TI", 
                239.23M, 
                100M);

            //Actual IInsurance object
            IInsurance tInsurance2 = new TravelInsurance(
                "88888888TI", 
                132.76M, 
                150M);

            //Console.WriteLine("\n************************\n");

            //Create a collection of IInsurance objects
            List<IInsurance> policies = new List<IInsurance>();
            policies.Add(tInsurance1);
            policies.Add(tInsurance2);
            //Here's the significant addition vvip bank accounts are IInsurance objects as well
            policies.Add(vvipAccount);

            //Renew all policies
            policies.ForEach(p => p.RenewPolicy());
            //Start claims on all IInsurance policies
            policies.ForEach(p => p.StartClaim());

            Console.ReadLine();
        }
    }
}
