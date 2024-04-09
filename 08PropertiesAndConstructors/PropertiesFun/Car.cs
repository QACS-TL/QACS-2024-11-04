using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesFun
{
    public class Car
    {

        public Car()
        {
            WheelCount = 4;
            Colour = "Silver";
            Speed = 0;
            Make = "Ford";
            Model = "Fiesta";

        }

        public Car(string make, string model, int wheelcount)
        {
            WheelCount = wheelcount;
            Colour = "Silver";
            Speed = 0;
            Make = make;
            Model = model;

        }

        public int WheelCount { get; set; }

        private string colour;

        //public string GetColour()
        //{
        //    return colour;
        //}

        //public void SetColour(string value)
        //{
        //    List<String> permittedColours = new List<string>(){ "Red", "Green", "Blue" };
        //    if (!permittedColours.Contains(value) )
        //    {
        //        value = "White";
        //    }
        //    colour = value;
        //}

        public string Colour
        {
            get { return colour; }
            set
            {
                List<String> permittedColours = new List<string>() { "Red", "Green", "Blue" };
                if (!permittedColours.Contains(value))
                {
                    value = "Silver";
                }
                colour = value; 
            }
        }



        private int speed;

        //Property with backing field
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        //Expression Bodied
        public int SpeedInMetresPerHour
        {
            get => (int)(speed * 1.61 * 1000); //Calculated
            
        }

        //Read only calculated property
        public int SpeedInKPH => (int)(speed * 1.61);

        //Auto-Implemented
        public string Make { get; set; }
        public string Model { get; private set; }


        public double EngineTempInDegreesCelcius { get; set; }
        public double EngineTempInDegreesFahrenheit
        {
            get { return EngineTempInDegreesCelcius * 1.8 + 32; }
        }
        //OR
        //public double EngineTempInDegreesFahrenheit => EngineTempInDegreesCelcius * 1.8 + 32; }

    }
}
