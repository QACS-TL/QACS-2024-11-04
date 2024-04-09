using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsComposition
{
    class TravelInsurance: Insurance
    {
        public TravelInsurance(
            string policyNumber, 
            decimal premium, 
            decimal excess, 
            string termsAndConditions = "Travel Blah, blah, blah"
            ) :base(policyNumber, premium, excess, termsAndConditions)
        {

        }

        public void StartClaim()
        {
            Console.WriteLine(
                $"Claim initiated on travel "
              + $"insurance policy number {PolicyNumber}");
        }
    }
}
