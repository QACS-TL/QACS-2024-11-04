using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public class SwitchGuardMeasuringFun
    {
        public static void DisplayMeasurements(int a, int b)
        {
            switch (a, b)
            {
                case (> 0, > 0) when a == b:
                    Console.WriteLine($"Both measurements are valid and equal to {a}.");
                    break;
                case ( > 0, > 0):
                    Console.WriteLine($"First measurement is {a}, second measurement is {b}.");
                    break;
                default:
                    Console.WriteLine($"One or both measurements are invalid.");
                    break;
            }
        }
    }
}
