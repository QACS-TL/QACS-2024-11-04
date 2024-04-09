using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndConstructors3
{
    internal class Employee
    {
        public Employee(string firstName, string lastName, int employeeID) { 
            FirstName = firstName;
            LastName = lastName;
            EmployeeID = employeeID;
        }
        // full properties with backing fields
        public string FirstName
        {
            get { return firstName; }
            init
            {
                if (value.Length > 0)
                {
                    FirstName = value;
                }
            }
        }
        public string LastName 
        {
            get { return  lastName.ToUpper(); }
            init 
            {
                if (value.Length > 0)
                {
                    lastName = value;
                }
            }
        }
        // backing fields
        private string firstName;
        private string lastName;
        // auto—implemented readonly property

        public int EmployeeID { get; }
    }
}
