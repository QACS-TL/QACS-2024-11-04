using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndConstructors3
{
    internal class Car
    {

        public Car()
        {
            Make = "Ford";
        }

        public Car(string make)
        {
            Make = make;
        }

        public Car(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public string Make { get; set; }
        public string Model { get; set; } = "Mondeo";
    }
}
