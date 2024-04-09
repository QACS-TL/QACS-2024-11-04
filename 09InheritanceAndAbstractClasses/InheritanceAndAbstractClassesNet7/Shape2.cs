using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClassesV2
{
    public abstract class Shape
    {
        public Color Colour { get; set; }
        public Point Position { get; set; }

        //Can still have base class constructors which specialised classes can invoke
        //but declare them as protected to make it clear to client code that direct
        //instantiation is not allowed
        protected Shape(Point position, Color colour)
        {
            Position = position; Colour = colour;
        }

        public abstract double Area { get; }  

        public abstract void Draw(Graphics canvas);

    }
}
