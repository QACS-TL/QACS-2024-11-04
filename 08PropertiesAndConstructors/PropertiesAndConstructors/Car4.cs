using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndConstructors4
{
    internal class Car
    {
        //parameter-less constructor
        public Car(): this("Unknown")
        {
        }

        //1 arg constructor
        public Car(string make): this(make, "Unknown model")
        {
        }

        //2 arg constructor
        public  Car(string make, string model)
        {
            Make = make;
            Model = model;
        }

        //public static Car CreateCar(string make, string model)
        //{
        //    Car c = new Car(make, model);
        //    return c;
        //}


        public string Make { get; set; }
        public string Model { get; set; }

        public int Speed { get; set; }
    }
}
