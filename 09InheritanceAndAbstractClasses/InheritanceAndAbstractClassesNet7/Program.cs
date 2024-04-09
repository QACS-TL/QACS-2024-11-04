using System.Drawing;
using System;
using InheritanceAndAbstractClassesV2;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;


namespace InheritanceAndAbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //05 & 06 Inheritance Example Graphics Application
            Shape shape = new Shape
            {
                Position = new Point(1, 1),
                Colour = Color.FromArgb(255, 0, 0)
            };
            Polygon polygon = new Polygon
            {
                Position = new Point(2, 2),
                Colour = Color.FromArgb(0, 255, 0),
                NumberOfSides = 7
            };
            Rectangle rectangle = new Rectangle
            {
                Position = new Point(3, 3),
                Colour = Color.FromArgb(0, 0, 255)
            };

            //07 Derived Constructors
            Ellipse e1 = new Ellipse((new Point(150, 10)), Color.Red, 50, 40);
            Ellipse e2 = new Ellipse(new Point(50, 100), Color.Green, 100, 100);
            Rectangle r1 = new Rectangle(new Point(200, 150), Color.Magenta, 75, 32);

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), e1.Colour.Name); ;
            Console.WriteLine($"Ellipse {nameof(e1)} is located at X:{e1.Position.X} Y:{e1.Position.Y} and with an X radius of {e1.XRadius} and a Y radius of {e1.YRadius} ");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), e2.Colour.Name); ;
            Console.WriteLine($"Ellipse {nameof(e2)} is located at X:{e2.Position.X} Y:{e2.Position.Y} and with an X radius of {e2.XRadius} and a Y radius of {e2.YRadius} ");
            Console.ForegroundColor = ConsoleColor.White;


            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), r1.Colour.Name); ;
            Console.WriteLine($"Rectangle {nameof(r1)} is located at X:{r1.Position.X} Y:{r1.Position.Y} and with a width of {r1.Width} and a height of {r1.Height} ");
            Console.ForegroundColor = ConsoleColor.White;


            //09, 10 and 12 Polymorphism Scenario
            using Bitmap bmp = new(600, 400);
            using Graphics gfx = Graphics.FromImage(bmp);
            gfx.Clear(Color.White);
            Drawing drawing = new Drawing();
            drawing.Shapes.Add(e1);
            drawing.Shapes.Add(e2);
            drawing.Shapes.Add(r1);
            drawing.Draw(gfx);
            bmp.Save("shapes.png");

            Console.WriteLine($"Area of Ellipse {nameof(e1)} is {e1.Area}");
            Console.WriteLine($"Area of Ellipse {nameof(e2)} is {e2.Area}");
            Console.WriteLine($"Area of rectangle {nameof(r1)} is {r1.Area}");

            Shape s1 = r1;

            Console.WriteLine($"Area of shape (which is really a rectangle) is {nameof(s1)} is {s1.Area}");

            shape.Draw(gfx);
            polygon.Draw(gfx);

            Console.WriteLine($"Area of Shape {nameof(shape)}: {(shape.Area == -1 ? "Area cannot be determined" : shape.Area)}");
            Console.WriteLine($"Area of Polygon {nameof(polygon)}: {(polygon.Area == -1 ? "Area cannot be determined" : polygon.Area)}");

            //14 and 15 Abstract Classes
            InheritanceAndAbstractClassesV2.Ellipse e3 = new(new Point(150, 10), Color.Red, 50, 40);
            InheritanceAndAbstractClassesV2.Ellipse e4 = new(new Point(50, 100), Color.Green, 100, 100);
            InheritanceAndAbstractClassesV2.Rectangle r2 = new(new Point(200, 150), Color.Magenta, 75, 32);

            //Cannot instantiate Abstract classes
            //InheritanceAndAbstractClassesV2.Shape shape2 = new (
            //    new Point(2,3), 
            //    Color.Purple
            //);

            //InheritanceAndAbstractClassesV2.Polygon polygon2 = new 
            //(
            //    new Point(2, 2),
            //    Color.FromArgb(0, 255, 0),
            //    7
            //);
            gfx.Clear(Color.White);
            InheritanceAndAbstractClassesV2.Drawing drawing2 = new();
            drawing2.Shapes.Add(e3);
            drawing2.Shapes.Add(e4);
            drawing2.Shapes.Add(r2);
            drawing2.Draw(gfx);
            bmp.Save("shapes2.png");

            Console.WriteLine($"Area of Ellipse {nameof(e3)} is {e3.Area}");
            Console.WriteLine($"Area of Ellipse {nameof(e4)} is {e4.Area}");
            Console.WriteLine($"Area of rectangle {nameof(r2)} is {r2.Area}");

            //Still OK to look at a specific 'Shape' (e.g. a Rectangle)
            //through the 'blinkers' of its base class
            InheritanceAndAbstractClassesV2.Shape s2 = r2;

            Console.WriteLine($"Area of shape (which is really a rectangle) is {nameof(s2)} is {s2.Area}");

            //Can't draw or calculates the area of objects that can't be instantiated
            //shape2.Draw(gfx);
            //polygon2.Draw(gfx);

            //Console.WriteLine($"Area of Shape {nameof(shape2)}: {(shape2.Area == -1 ? "Area cannot be determined" : shape2.Area)}");
            //Console.WriteLine($"Area of Polygon {nameof(polygon2)}: {(polygon2.Area == -1 ? "Area cannot be determined" : polygon2.Area)}");


            //17 Up and Down Casting
            Drawing app = new Drawing();
            Ellipse e = new Ellipse(new Point(150, 10), Color.Red, 50, 40);
            Rectangle r = new Rectangle(new Point(200, 150), Color.Magenta, 75, 32);

            app.Shapes.Add(e); //implicit upcasting
            app.Shapes.Add(r); //implicit upcasting
            app.Shapes.Add(null);

            Shape s = app.Shapes[0];
            s.Draw(gfx); // an Ellipse is drawn
            Ellipse ell = (Ellipse)s; // explicit downcasting
            double area = ell.Area;

            Console.WriteLine(area);

            Shape shape2 = app.Shapes[1]; //Second shape in collection (which is a rectangle)
            shape2.Draw(gfx); // a Rectangle is drawn
            //Ellipse ell2 = (Ellipse)shape2; // explicit downcasting. Will generate run time error because shape is not an ellipse 
            //area = ell2.Area;
            //Console.WriteLine(area);


            //19 The "is" operator
            Shape shape3 = app.Shapes[0];
            foreach (Shape sh in app.Shapes)
            {
                if (sh is not null && sh is Ellipse ellipse)
                {
                    double circumference = ellipse.Circumference;
                    Console.WriteLine(circumference);
                }
                else
                {
                    if (sh is not null)
                    {
                        Console.WriteLine($"Shape is not an ellipse. In actual fact it's a {sh.GetType()}");
                    }
                    else
                    {
                        Console.WriteLine($"Shape is null!");
                    }
                }
            }

            //20 The "as" operator
            Ellipse? ellipse2 = shape3 as Ellipse;
            if (ellipse2 != null)
            {
                double circumference = ellipse2.Circumference;
                Console.WriteLine($"Circumference of ellipse is {circumference}");
            }

            if (ellipse2 is not null)
            { 
                double circumference = ellipse2.Circumference;
                Console.WriteLine($"Circumference of ellipse is {circumference}");
            }

            //22 and 23 Overriding Object Methods
            Book b1 = new();
            b1.Author = "J K Rowling";
            b1.Title = "Harry Potter and the Philospher's Stone";
            b1.ISBN = 9789590353403;
            Book b2 = new();
            b2.Author = "J K Rowling";
            b2.Title = "Harry Potter and the Philospher's Stone";
            b2.ISBN = 9789590353403;

            Console.WriteLine(b1.ToString()); // Title=Harry Potter and the Philospher's Stone, Author=J K Rowling
            Console.WriteLine(b1.GetHashCode()); //  978059035
            Console.WriteLine(b1.Equals(b2)); //True (value equality)
            Console.WriteLine(b1 == b2); // False (reference equality)

            Book b3 = b1;
            Console.WriteLine(b1.Equals(b3)); // True (value equality)
            Console.WriteLine(b1 == b3) ; // True (reference equality)

            //25 Sealed Classes
            //See code for ClassA, ClassB and ClassC

            //26 Sealed Methods
            //See code for ClassX, ClassY and ClassZ
        }
    }
}