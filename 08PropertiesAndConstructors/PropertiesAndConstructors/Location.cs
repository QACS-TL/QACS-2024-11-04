using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndConstructors
{
    public class Location
    {
        //private backing field
        private string locationName;

        //expression bodied constructor
        public Location(string name) => Name = name;

        public string Name 
        { 
            get => locationName; 
            set => locationName = value; 
        }

    }
}
