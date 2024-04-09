using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IEmployee
    {
        public int ID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        
        public double Salary
        { 
            get; 
            set; 
        }

        public double GetTaxAmount()
        {
            return Salary * 0.05;
        }
    }
}
