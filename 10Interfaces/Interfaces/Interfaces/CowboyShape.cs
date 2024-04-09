using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class CowboyShape : ICowboy, IDrawable
    {
        //public void Draw(Graphics g)
        //{
        //    //Do I draw a gun?
        //    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        //    Pen pen = new Pen(Color.Black, 5);
        //    g.DrawRectangle(pen, new System.Drawing.Rectangle(20, 20, 200, 40));
        //    g.DrawRectangle(pen, new System.Drawing.Rectangle(20, 60, 50, 60));
        //    g.DrawArc(pen, new System.Drawing.Rectangle(50, 40, 45, 40), 0, 90);
        //    g.DrawLine(pen, new Point(80, 60), new Point(80, 70));

        //    //Or Shoot my gun?
        //    //Or both?
        //    //Think of the consequences if I do the wrong thing...
        //    Gun gun = new Gun();
        //    gun.Shoot();
        //}
        void ICowboy.Draw(Graphics g)
        {
            //Reach for the sky!
            Gun gun = new Gun();
            Console.WriteLine(gun.Shoot());
        }

        void IDrawable.Draw(Graphics g)
        {
            //Drawing a gun
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen pen = new Pen(Color.Black, 5);
            g.DrawRectangle(pen, new System.Drawing.Rectangle(20, 20, 200, 40));
            g.DrawRectangle(pen, new System.Drawing.Rectangle(20, 60, 50, 60));
            g.DrawArc(pen, new System.Drawing.Rectangle(50, 40, 45, 40), 0, 90);
            g.DrawLine(pen, new Point(80, 60), new Point(80, 70));

        }
    }
}
