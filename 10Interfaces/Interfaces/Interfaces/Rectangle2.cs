using Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesV2
{
    internal class Rectangle: Shape, IDrawable, IComparable<Rectangle>
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

        public int CompareTo(Rectangle? other)
        {
            //What makes one rectangle bigger than another?
            //One with the biggest area or if areas are the 
            //same then the one with the biggest width
            double widthComparison = Width - other.Width;
            double heightComparison = Height - other.Height;
            double area = Width * Height;
            double otherArea = other.Width * other.Height;
            double areaComparison = area - otherArea;
            if (areaComparison > 0 || (areaComparison == 0 && widthComparison > 0))
            {
                return +1;
            }
            else if (areaComparison < 0 || (areaComparison == 0 && widthComparison < 0))
            {
                return -1;
            }
            //rectangles must have same area, widths and heights
            return 0;
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
