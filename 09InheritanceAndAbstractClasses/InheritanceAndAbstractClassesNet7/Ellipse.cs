using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClasses
{
    public class Ellipse: Shape
    {
        public int XRadius { get; set; }
        public int YRadius { get; set; }

        public Ellipse(): this(new Point(0,0), Color.Black, 1,1)
        {

        }
        public Ellipse(Point position, Color colour, int xRadius, int yRadius)
            : base(position, colour) //chain to base class constructor
        {
            XRadius = xRadius;
            YRadius = yRadius;
        }

        public override void Draw(Graphics canvas)
        {
            canvas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(this.Colour, 5  );
            canvas.DrawEllipse(pen, this.Position.X, this.Position.Y, XRadius, YRadius);
        }
        public override double Area
        {
            get
            {
                return (Math.PI * XRadius * YRadius);
            }
        }
        public double Circumference
        {
            //Note, to exactly calculate the circumference of an ellipse is mathematically tricky
            // and involves the use of integration that has no easy solutions. There is, however
            //an easier way of calculating the approximate circumference.
            //See: https://www.omnicalculator.com/math/ellipse-circumference
            get
            {
                if (XRadius < YRadius)
                {
                    //Swap
                    int temp = XRadius;
                    XRadius= YRadius;
                    YRadius= temp;
                }
                double h = Math.Pow((XRadius - YRadius), 2) / Math.Pow((XRadius + YRadius), 2);
                double circumference = Math.PI * (XRadius + YRadius) * (1 + ((3 * h) / (10 + Math.Sqrt(4 - 3 * h))));
                return circumference;
            }
        }
    }
}
