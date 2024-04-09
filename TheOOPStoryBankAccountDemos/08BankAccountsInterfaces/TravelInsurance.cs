using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsInterfaces
{
    class TravelInsurance: IInsurance
    {

        public TravelInsurance(
            string policyNumber, 
            decimal premium, 
            decimal excess, string 
            termsAndConditions = "Travel Blah, blah, blah")
        {
            PolicyNumber = policyNumber;
            Premium = premium;
            Excess = excess;
            TermsAndConditions = termsAndConditions;
        }

        public string PolicyNumber { get; set; }
        public decimal Premium { get; set; }
        public decimal Excess { get; set; }
        public string TermsAndConditions { get; set; }

        public virtual void RenewPolicy()
        {
            Console.WriteLine(
                $"Travel Insurance policy number "
              + $"{PolicyNumber} has been renewed");
        }

        public void StartClaim()
        {
            Console.WriteLine(
                $"Claim initiated on travel insurance "
              + $"policy number {PolicyNumber}");
        }
    }
}
