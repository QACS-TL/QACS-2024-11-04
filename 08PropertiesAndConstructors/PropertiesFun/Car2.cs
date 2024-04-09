using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesFun
{
    public class Car2
    {
        ////parameter—less constructor
        //public Car2() {
        //    Make = "Unkown";
        //}

        //// 1 arg constructor 
        //public Car2(string make) {
        //    Make = make;
        //}

        //// 2 arg constructor
        //public Car2(string make, string model) { 
        //    Make = make;
        //    Model = model;
        //}

        //parameter—less constructor
        public Car2():this("Unkown")
        {
            Make = "Unkown";
        }

        // 1 arg constructor 
        public Car2(string make)
        {
            Make = make;
        }

        // 2 arg constructor
        public Car2(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public string Make { get; set; }
        public string Model { get; set; }

    }
}
