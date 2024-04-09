using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndConstructors4
{
    internal class Employee
    {
        public static readonly string companyName;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int EmployeeID { get; private set; }
        public long OfficeSeatNumber { get; private set; } = -1;

        // Static constructor is called at most one time, before any
        // instance constructor is invoked or member is accessed.
        static Employee()
        {
            companyName = "QA Ltd";
        }

        public Employee() : this("Jane", "Doe")
        {

        }

        public Employee(string firstName, string lastName) : this(firstName, lastName, -1)
        {

        }

        public Employee(string firstName, string lastName, int employeeID)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmployeeID = employeeID;
            AllocateSeatInTheOffice(this);
        }

        public void AllocateSeatInTheOffice(Employee emp)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            OfficeSeatNumber = random.NextInt64(1, 100);
        }


    }
}
