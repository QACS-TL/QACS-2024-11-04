using System;
using System.Drawing;
using System.Security.Cryptography;

namespace Interfaces
{
    internal class Program
    {
        private static Graphics canvas;

        static void Main(string[] args)
        {
            using Bitmap bmp = new(600, 400);
            canvas = Graphics.FromImage(bmp);
            canvas.Clear(Color.White);

            //05 and 07 Implementing and Interface, Polymorphism
            List<Shape> shapes = new(){ new Rectangle(new Point(100, 50), Color.Red, 120, 70), new Rectangle(new Point(110, 60), Color.Blue, 100, 40) };
            foreach (Shape shape in shapes)
            {
                if (shape is IDrawable s)
                {
                    s.Draw(canvas);
                    //or:
                    ProcessDrawable(shape as IDrawable);
                }
            }
            bmp.Save("Shapes.png");

            //08 Multiple Interfaces
            List<InterfacesV2.Rectangle> rectangles = new();
            InterfacesV2.Rectangle rect1 = new(new Point(100, 50), Color.Red, 120, 70);
            InterfacesV2.Rectangle rect2 = new(new Point(100, 50), Color.Red, 120, 70);
            InterfacesV2.Rectangle rect3 = new(new Point(100, 50), Color.Red, 80, 50);
            InterfacesV2.Rectangle rect4 = new(new Point(100, 50), Color.Red, 60, 60);
            InterfacesV2.Rectangle rect5 = new(new Point(100, 50), Color.Red, 40, 90);
            InterfacesV2.Rectangle rect6 = new(new Point(100, 50), Color.Red, 90, 40);
            InterfacesV2.Rectangle rect7 = new(new Point(100, 50), Color.Red, 30, 40);
            InterfacesV2.Rectangle rect8 = new(new Point(100, 50), Color.Red, 20, 60);
            InterfacesV2.Rectangle rect9 = new(new Point(100, 50), Color.Red, 40, 30);
            InterfacesV2.Rectangle rect10 = new(new Point(100, 50), Color.Red, 60, 20);

            rectangles.AddRange(new InterfacesV2.Rectangle[] { rect1, rect2, rect3,rect4, rect5, rect6, rect7, rect8, rect9, rect10 });
            rectangles.Sort();
            Console.WriteLine("Rectangles in ascending sequence of size:");
            foreach (InterfacesV2.Rectangle r in rectangles)
            {
                Console.WriteLine($"area={r.Area}, width={r.Width}, Height={r.Height}");
            }

        //09 Default Implementation
            IEmployee employeeA = new Employee(2500);
            Console.WriteLine($"Tax amount is { employeeA.GetTaxAmount() }");
            Console.ReadKey();

            //To access the default implementation, the declared
            //type must be the interface type not the implementing
            //class or struct type.
            Employee employeeB = new Employee(2500);
            //Console.WriteLine($"Tax amount is {employeeB.GetTaxAmount() }");
            Console.ReadKey();


        //10 Interfaces can inherit from interfaces
            IFullySteerable drone = new Drone();
            drone.TurnRight();
            drone.TurnLeft();
            drone.GoUp();
            drone.GoDown();

        //12 and 13 Multiple Interface Member Collisions
            canvas.Clear(Color.White);

            CowboyShape cowboyShape= new CowboyShape();
            IDrawable id = cowboyShape;
            id.Draw(canvas); // draws picture
            bmp.Save("cowboy.png");

            ICowboy ic = cowboyShape;
            ic.Draw(canvas); // Shoots gun


        }

        static void ProcessDrawable(IDrawable id)
        {
            if (id is not null)
                id.Draw(canvas);
        }

    }
}