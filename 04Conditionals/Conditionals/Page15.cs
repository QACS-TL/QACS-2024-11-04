using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public readonly struct Point
    {
        public Point(int x, int y) => (X, Y) = (x, y);
        // a constructor expression—bodied method
        // take x and assign it to X
        // take y and assign it to Y

        public int X { get; }
            // readonly property X

        public int Y { get; }
        // readonly property Y
    }
    public class SwitchExpressionCaseGuard
    {
        static Point Transform(Point point) => point switch
        {
            { X: 0, Y: 0 } => new Point(0, 0),
            { X: var x, Y: var y } when x < y => new Point(x + y, y),
            { X: var x, Y: var y } when x > y => new Point(x - y, y),
            { X: var x, Y: var y } => new Point(2 * x, 2 * y)

        };

        public static void DoTransforms() {
            Point p = new Point(2, 4);
            Point transformedP = Transform(p);
            Console.WriteLine($"X is {transformedP.X} and Y is {transformedP.Y}");
            // Output:
            // X is 6 and Y is 4
            Point p2 = new Point(7, 3);
            Point transformedP2 = Transform(p2);
            Console.WriteLine($"X is {transformedP2.X} and Y is {transformedP2.Y}");
            // Output:
            // X is and Y is 3
            Point p3 = new Point(6, 6);
            Point transformedP3 = Transform(p3);
            Console.WriteLine($"X is { transformedP3.X } and Y is { transformedP3.Y }");
            // Output:
            // X is 12 and Y is 12
        }
    }
}
