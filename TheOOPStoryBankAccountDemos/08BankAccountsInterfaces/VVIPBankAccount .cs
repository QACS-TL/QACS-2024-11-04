using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsInterfaces
{
    class VVIPBankAccount:SavingsAccount, IInsurance
    {
        private TravelInsurance privateTravelInsurance;

        public VVIPBankAccount(
            string accountNumber,
            string accountHolderName,
            decimal balance = 0.00M,
            decimal interestRate = 0.5M,
            decimal insuranceExcess = 100.00M
            ) : base(
                accountNumber,
                accountHolderName,
                balance,
                interestRate)
        {
            privateTravelInsurance = new TravelInsurance(
                accountNumber + "PTI",
                0.00M, //No premium, insurance comes for free with VIP account
                insuranceExcess);
        }

        //Wrapper methods for private version of Travel Insurance
        public string PolicyNumber { 
            get {
                return privateTravelInsurance.PolicyNumber;
            }
            private set {
                privateTravelInsurance.PolicyNumber = value;
            }
        }

        public decimal Premium {
            get {
                return privateTravelInsurance.Premium;
            }
            private set {
                privateTravelInsurance.Premium = value;
            }
        }

        public decimal Excess {
            get {
                return privateTravelInsurance.Excess;
            }
            set {
                privateTravelInsurance.Excess = value;
            }
        }

        public string TermsAndConditions { 
            get {
                return privateTravelInsurance.TermsAndConditions;
            }
            set {
                privateTravelInsurance.TermsAndConditions = value;
            }
        }

        public void RenewPolicy()
        {
            privateTravelInsurance.RenewPolicy();
        }

        public void StartClaim()
        {
            privateTravelInsurance.StartClaim();
        }
    }
}
