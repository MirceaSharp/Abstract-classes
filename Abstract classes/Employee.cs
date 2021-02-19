using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    abstract class Employee
    {
        private string _firstName;
        private string _lastName;
        private decimal _salary;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public decimal Salary { get; set;}

        public Employee(string firstName, string lastName, decimal salary)
        {

            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public abstract decimal Income();
        

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return base.ToString();
        }


    }
}
