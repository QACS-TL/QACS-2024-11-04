using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClasses
{
    internal class Polygon: Shape
    {
        public int NumberOfSides { get; set; }

        public Polygon()
        {

        }

        public Polygon(Point position, Color colour, int numberOfSides):base(position, colour)
        {
            NumberOfSides= numberOfSides;
        }

        public override void Draw(Graphics canvas)
        {
            base.Draw(canvas);
        }

        public override double Area => base.Area;
    }
}
