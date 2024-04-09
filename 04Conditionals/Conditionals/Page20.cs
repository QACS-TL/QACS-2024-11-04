using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional
{ 
    internal class NullOperators 
    {
        public static void Addressing() 
        {
            // null-coalescing operator
            int? a = null; // null;
            int b = a ?? -1;
            Console.WriteLine(b); // output: -1
            // null-coalescing assignment operator
            string address = "1 Main Street ";
            string? country = null;
            string addressAndCountry = (address + (country ??= "UK"));
            Console.WriteLine(addressAndCountry);
            // null—conditional operator accessing Length member
            // combined with null-coalescing operator
            country = null;
            int? countryLength = country?.Length ?? 0;
            Console.WriteLine(countryLength); // 2
            string? postcode = null;
            int postcodeLength = postcode?.Length ?? 0;
            //int postcodeLength2 = postcode.Length;
            Console.WriteLine(postcodeLength); // 0
        }
    }
}
