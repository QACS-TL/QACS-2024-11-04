using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClasses
{
    public class ClassX
    {
        protected virtual void F1() { Console.WriteLine("X.F1"); }
        protected virtual void F2() { Console.WriteLine("X.F2"); }
    }
}
