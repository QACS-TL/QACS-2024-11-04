using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratch
{
    public class Car
    {
        public string Make { get; set; }
        public int Speed { get; set; }
        public byte CurrentGear { get; set; }

        public void Accelerate(int weightOfFoot)
        {
            Speed = Speed + weightOfFoot; 
        }
    }
}
