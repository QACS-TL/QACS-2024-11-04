using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClassesV2
{
    public abstract class Polygon: Shape
    {
        public int NumberOfSides { get; set; }

        //Can still have base class constructors which specialised classes can invoke
        //but declare them as protected to make it clear to client code that direct
        //instantiation is not allowed
        public Polygon(Point position, Color colour, int numberOfSides) : base(position, colour)
        {
            NumberOfSides = numberOfSides;
        }
    }
}
