using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsInterfaces
{
    public interface IInsurance
    {
        string PolicyNumber { get; }
        decimal Premium { get; }
        decimal Excess { get; set; }
        string TermsAndConditions { get; set; }

        void StartClaim();
        void RenewPolicy();
    }
}
