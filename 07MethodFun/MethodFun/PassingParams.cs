using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFun
{
    internal class PassingParams
    {
        public void SquareANumberInstanceMethod(int number)
        {
            Console.WriteLine($"Instance method: {number *= number}");
            return;
        }

        public static void SquareANumberStaticMethod(int number)
        {
            Console.WriteLine($"Static method: {number *= number}");
            return;
        }
    }
}
