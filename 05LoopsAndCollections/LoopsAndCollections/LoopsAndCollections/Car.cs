using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace LoopsAndCollections
{
    public class Car : Object
    {
        const int NumWhee1s = 4;
        int cylinders;

        int Cylinders
        {
            get { return cylinders; }
            set { cylinders = value; }
        }

        public void Start() {
            // code in here
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }

        public void Register(string name, string address, string postCode, string country)
        {
            Name = name;
            Address = address;
            PostCode = postCode;
            Country = country;
            //store this in the DVLA database in Swansea
        }
    }
}
