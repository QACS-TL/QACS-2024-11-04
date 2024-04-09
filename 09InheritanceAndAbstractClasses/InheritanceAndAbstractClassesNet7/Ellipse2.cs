using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClassesV2
{
    public class Ellipse: Shape
    {
        public int XRadius { get; set; }
        public int YRadius { get; set; }

        public Ellipse(Point position, Color colour, int xRadius, int yRadius)
            : base(position, colour) //chain to base class constructor
        {
            XRadius = xRadius;
            YRadius = yRadius;
        }

        public override void Draw(Graphics canvas)
        {
            canvas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(this.Colour, 5);
            canvas.DrawEllipse(pen, this.Position.X, this.Position.Y, XRadius, YRadius);
        }
        public override double Area
        {
            get
            {
                if (XRadius < YRadius)
                {
                    //swap
                    int temp = XRadius;
                    XRadius = YRadius;
                    YRadius = temp;
                }
                return (Math.PI * XRadius * YRadius);
            }
        }
    }
}
