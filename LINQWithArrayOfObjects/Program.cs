using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQWithArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new[]
            {
                new Employee("Jason", "Red", 5000M),
                new Employee("Ashley", "Green", 7600M),
                new Employee("Mathew", "Indigo", 3587M),
                new Employee("James", "Indigo", 4700M),
                new Employee("Luke", "Indigo", 6200M),
                new Employee("Jason", "Blue", 3200M),
                new Employee("Wendy", "Brown", 4236M),
            };
            //display all the employees

            Console.WriteLine("Orginal array: ");
            foreach (var item in employee)
            {
                Console.WriteLine(item);
            }
            //filter a range of salaries using && in a LINQ query
            var between4K6K =
                from value in employee
                where (value.MonthlySalary >= 4000M && value.MonthlySalary <= 6000)
                select value;
            //display employees making between 4000 and 6000 per month
            Console.WriteLine("\nEmployees earning in the range "+ $"{4000:C} - {6000:C} per month: ");
            foreach (var item in between4K6K)
            {
                Console.WriteLine(item);
            }
            //order the employees by last name, then firstname with LINQ
            var nameSorted =
                from name in employee
                orderby name.LastName, name.FirstName
                select name;

            Console.WriteLine("First Employees sorted by name");
            //attempt to display the first result of the above LINQ query 
            if(nameSorted.Any())
            {
                Console.WriteLine(nameSorted.First());
            }
            else
            {
                Console.WriteLine("Not found");
            }
            //use LINQ to select employee last names
            var lastNames =
                from name in employee
                select name.LastName;

            //use method Distinct to select unique last names
            Console.WriteLine("\n Unique employee last names: ");
            foreach (var item in lastNames.Distinct())
            {
                Console.WriteLine(item);
            }
            //use LINQ to select firstName and lastName
            var names =
                from name in employee
                select new {name.FirstName, name.LastName };

            //display full names
            Console.WriteLine("Names only");
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
