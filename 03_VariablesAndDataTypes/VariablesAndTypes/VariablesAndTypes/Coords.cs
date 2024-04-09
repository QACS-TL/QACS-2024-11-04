using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndTypes
{
    public readonly struct Coords
    {
        // Constructor
        // It is called when an instance is created and is used to initialize the instance
        public Coords(double x, double y)
        {
            X = x;
            Y = y;
        }
        // Auto—implemented properties: X and Y
        // A getter enables a property value to be read
        // An init—only setter assigns a value to the property only during object construction
        public double X { get; init; }
        public double Y { get; init; }

        //public override string ToString()
        //{
        //    return $"X:{X}, Y:{Y}";
        //}
    }
}
