using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsComposition
{
    class VIPBankAccount:SavingsAccount
    {
        public TravelInsurance TravelInsurancePolicy
        {
            get { return privateTravelInsurance; }
            private set { privateTravelInsurance = value; }
        }
        private TravelInsurance privateTravelInsurance;

        public VIPBankAccount(
            string accountNumber, 
            string accountHolderName, 
            decimal balance = 0.00M,
            decimal interestRate = 0.5M,
            decimal insuranceExcess = 100.00M
            ) : base (
                accountNumber, 
                accountHolderName, 
                balance, 
                interestRate)
        {
            privateTravelInsurance = new TravelInsurance(
                accountNumber + "TI", 
                0.00M, //No premium, insurance comes for free with VIP account
                insuranceExcess);
        }

        //Wrapper methods for private version of Travel Insurance
        public string TravelInsurancePolicyNumber {
            get {
                return privateTravelInsurance.PolicyNumber;
            }
        }

        public decimal TravelInsurancePremium {
            get {
                return privateTravelInsurance.Premium;
            }
        }

        public decimal TravelInsuranceExcess {
            get {
                return privateTravelInsurance.Excess;
            }
            set {
                privateTravelInsurance.Excess = value;
            }
        }

        public void StartTravelInsuranceClaim()
        {
            privateTravelInsurance.StartClaim();
        }
    }
}
