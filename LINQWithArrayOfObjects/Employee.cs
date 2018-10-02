using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQWithArrayOfObjects
{
    class Employee
    {
        public string FirstName { get; } //read-only auto implemented property
        public string LastName { get; } //read-only auto implemented property
        private decimal monthlySalary; //monthly salary of emloyee

        public Employee(string firstName, string lastName, decimal monthlySalary)
        {
            FirstName = firstName;
            LastName = lastName;
            MonthlySalary = monthlySalary;
        }

        public decimal MonthlySalary
        {
            get { return this.monthlySalary; }
            set
            {
                if (value >= 0M)
                {
                    this.monthlySalary = value;
                }
            }
        }
        public override string ToString() =>
        $"{FirstName, -10} {LastName, 10:C}";
    }
}
