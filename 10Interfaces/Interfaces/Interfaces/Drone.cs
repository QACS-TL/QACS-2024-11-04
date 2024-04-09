using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Drone : IFullySteerable
    {
        public void GoDown()
        {
            string arrows = string.Concat(Enumerable.Repeat(char.ConvertFromUtf32(0x2193), 6));
            Console.WriteLine($"Going Down{arrows}!");
        }

        public void GoUp()
        {
            string arrows = string.Concat(Enumerable.Repeat(char.ConvertFromUtf32(0x2191), 6));
            Console.WriteLine($"Going Up{arrows}!");
        }

        public void TurnLeft()
        {
            Console.WriteLine("Going Left<<<<<<!");
        }

        public void TurnRight()
        {
            Console.WriteLine("Going Right>>>>>>!"); ;
        }
    }
}
