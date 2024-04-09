using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndConstructors
{
    public  class Temperature
    {
        public double TempInDegreesCelcius { get;  set; }

        public double TempInDegreesFarenheit
        {
            get { return TempInDegreesCelcius * 1.8 + 32; }
        }

        //Alternatively:
        public double TempInDegreesFarenheitAlt=>  TempInDegreesCelcius * 1.8 + 32; 

    }
}
