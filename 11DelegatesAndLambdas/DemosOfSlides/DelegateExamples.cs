using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosOfSlides
{
    internal class DelegateExamples
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public void DisplayGreeting(string name)
        {
            Console.WriteLine($"Hello {name}" );
        }


        public static void DisplayGreetingStatic(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
