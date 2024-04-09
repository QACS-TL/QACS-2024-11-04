using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClassesV2
{
    internal class Drawing
    {
        private List<Shape> shapes;
        public List<Shape> Shapes
        {
            get
            {
                // null—coalescing assignment operator
                if (shapes == null)
                {
                    shapes = new List<Shape>();
                }
                return shapes;
            }
        }

        public void Draw(Graphics canvas)
        {
            foreach
            (Shape shape in Shapes)
            {
                shape.Draw(canvas);
            }
            // all shapes must have a Draw method
        }
    }
}
