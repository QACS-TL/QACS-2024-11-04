using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PropertiesFun
{
    public class Location
    {
        // private backing field
        private string locationName;
        // expression bodied constructor

        public Location(string name) => Name = name;

        public string Name
        {
            // expression bodied property accessors
            get => locationName;
            set => locationName = value;
        }
    }
}
