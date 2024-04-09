using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndConstructors
{
    internal class Employee
    {
        public readonly string firstName;
        public readonly string lastName;
        public readonly int employeeID;

        public Employee()
        {

        }

        public Employee(string firstname, string lastname, int employeeID)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.employeeID = employeeID;
        }
    }
}
