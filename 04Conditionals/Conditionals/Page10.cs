using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public class SwitchExpressionParliamentFun
    {
        public static string GetParliament(Country country) => country switch
        {
            Country.England => "Westminster",
            Country.NorthernIreland => "Northern Ireland Assembly",
            Country.Scotland => "Holyrood",
            Country.Wales => "Senedd Cymru",
            _ => "Unknown Parliament"
        };
    }
}
