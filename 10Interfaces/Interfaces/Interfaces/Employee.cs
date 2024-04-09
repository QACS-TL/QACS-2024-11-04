using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Employee : IEmployee
    {
        public Employee(double salary)
        {
            Salary = salary;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
}
