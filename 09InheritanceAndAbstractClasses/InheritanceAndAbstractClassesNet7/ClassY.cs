using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClasses
{
    public class ClassY: ClassX
    {
        sealed protected override void F1() { Console.WriteLine("Y.F1"); }
        protected override void F2() { Console.WriteLine("Y.F2"); }

    }
}
