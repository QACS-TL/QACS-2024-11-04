using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClasses
{
    public class ClassZ: ClassY
    {
        //Attempting to override causes compiler error CS0239
        //protected override void F1() { Console.WriteLine("Z.F1"); }

        //Overriding F2 is allowed
        protected override void F2() { Console.WriteLine("Z.F2"); }

    }
}
