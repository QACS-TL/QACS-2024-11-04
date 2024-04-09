using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndConstructors2
{
    internal class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public int EmployeeID { get; }

        public Employee()
        {

        }

        public Employee(string firstname, string lastname, int employeeID)
        {
            FirstName = firstname;
            LastName = lastname;
            EmployeeID = employeeID;
        }
    }
}
