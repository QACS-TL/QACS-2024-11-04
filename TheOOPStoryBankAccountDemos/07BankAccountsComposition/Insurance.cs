using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsComposition
{
    abstract class Insurance
    {
        public string PolicyNumber { get; set; }
        public decimal Premium { get; set; }
        public decimal Excess { get; set; }
        public string TermsAndConditions { get; set; }

        public Insurance(
            string policyNumber, 
            decimal premium, 
            decimal excess, 
            string termsAndConditions = "Blah, blah, blah")
        {
            PolicyNumber = policyNumber;
            Premium = premium;
            Excess = excess;
            TermsAndConditions = termsAndConditions;
        }
    }
}
