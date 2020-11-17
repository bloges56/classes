using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //create three employees and add them to a list
            Employee ammarah = new Employee("Ammarah", "Lara", "accountant", new DateTime(1995, 11, 18));
            Employee marwah = new Employee("Marwah", "Boyce", "manager", new DateTime(2002, 8, 10));
            Employee jon = new Employee("Jonathon", "Mccray", "crew member", new DateTime(2013, 3, 22));

            List<Employee> employees = new List<Employee>()
            {
                ammarah, marwah, jon
            };

            //create a company
            DateTime dateFounded = new DateTime(2000, 1, 1);
            Company myCompany = new Company("Logan Games", employees, dateFounded);

            //list the employees in the console
            myCompany.ListEmployees();


        }
    }
}
