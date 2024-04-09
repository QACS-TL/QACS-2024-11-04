using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndTypes
{
    public class ScopeOfVariables
    {
        int visibleToEntireType;
        // variables at class scope (Fields)

        int methodA()
        {
            visibleToEntireType = 42;
            int onlyVisibleWithinMethod = 13;
            // block created with braces
            {
                int onlyVisibleWithinBlock = 5;
                return onlyVisibleWithinBlock + onlyVisibleWithinMethod;
            }
            //onlyVisibleWithinBlock = 7; //not visible outside of the block (compile error)
        }

        void MethodB() {
            visibleToEntireType = 21;
            //onlyVisibleWithinMethod = 50; //not visible outside of MethodA (compile error)
        }
    }

}
