using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesFun
{
    public class Employee
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly int employeeID;

        public Employee(string firstName, string lastName, int employeeID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.employeeID = employeeID;
        }

        //public Employee(string firstName, string lastName, int employeeID)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //    EmployeeID = employeeID;
        //}
        //
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public int EmployeeID { get; set; }


    }
}
