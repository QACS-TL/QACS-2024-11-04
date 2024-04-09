using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFun
{
    internal static class StringUtils
    {
        public static int WordCount(this string theString)
        {
            if (theString == null || theString.Trim() == string.Empty) return 0;
            return theString.Trim().Split(' ').Count();
        }
    }
}
