using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public class MeasuringFun
    {
        public static void DisplayMeasurement(double measurement)
        {
            switch (measurement) {
                case < 0.0:
                    Console.WriteLine($"Measured value is {measurement}; too low.");
                    break;
                case > 15.0:
                    Console.WriteLine($"Measured value is {measurement}; too high.");
                    break;
                case double.NaN:
                    Console.WriteLine("Failed measurement. ");
                    break;
                default:
                    Console.WriteLine($"Measured value is {measurement}.");
                    break;
            }
        }
    }
}
