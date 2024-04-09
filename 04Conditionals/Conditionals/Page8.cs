using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public class ParliamentsFun
    {
        public static void GetParliament(Country country)
        {
            string parliamentName;
            switch (country) {
                case Country.England:
                    parliamentName = "Westminster";
                    break;
                case Country.NorthernIreland:
                    parliamentName = "Northern Ireland Assembly";
                    break;
                case Country.Scotland:
                    parliamentName = "Holyrood";
                    break;
                case Country.Wales:
                    parliamentName
                    = "Senedd Cymru";
                    break;
                default:
                    parliamentName = "Unknown Parliament";
                    break;
            }
            Console.WriteLine(parliamentName);
        }
    }
}
