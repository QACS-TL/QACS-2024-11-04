using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Rectangle: Shape, IDrawable
    {
        public int Width { get; set; }
        public int Height { get; set; } 
        public Rectangle() : this(new Point(0, 0), Color.Black, 10, 10)
        {

        }
        public Rectangle(Point position, Color colour, int width, int height) : base(position, colour)
        {
            Width = width;
            Height = height;
        }

        public override void Draw(Graphics canvas)
        {
            canvas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(this.Colour, 5);
            canvas.DrawRectangle(pen, new System.Drawing.Rectangle(this.Position.X, this.Position.Y, Width, Height));
        }

        public override double Area
        {
            get
            {
                return Width * Height;
            }
        }
    }
}
