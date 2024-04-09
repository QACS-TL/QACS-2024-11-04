using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IFullySteerable: ISteerable
    {
        void GoUp();
        void GoDown();
    }
}
