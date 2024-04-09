using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsInterfaces
{
    class VIPBankAccount:BankAccount
    {
        public IInsurance TravelInsurancePolicy {
            get { return privateTravelInsurance;  }
            private set { privateTravelInsurance = value; }
        }
        private IInsurance privateTravelInsurance;

        public VIPBankAccount(string accountNumber, string accountHolderName) : this(accountNumber, accountHolderName, 0)
        {

        }

        public VIPBankAccount(string accountNumber, string accountHolderName, decimal balance): base (accountNumber, accountHolderName, balance)
        {
            TravelInsurancePolicy = new TravelInsurance(accountNumber + "TI", 0.00M, 100.00M);
            //privateTravelInsurance = new TravelInsurance(accountNumber + "PTI", 0.00M, 100.00M);
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
