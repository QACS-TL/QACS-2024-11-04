using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndConstructors2
{
    internal class Car
    {
        private int speed;
        private int engineSize;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int EngineSize
        {
            get => engineSize; 
            set => engineSize = value; 
        }

        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "Mondeo";
        public int NumberOfDoors { get; private set; } = 5;
    }
}
