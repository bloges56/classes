using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {
        private string _name;
        private DateTime _dateFounded;
        private List<Employee> _employees = new List<Employee>();

        public Company(string name, List<Employee> employees, DateTime datefounded)
        {
            _name = name;
            _employees = employees;
            _dateFounded = datefounded;
        }

        public void ListEmployees()
        {
            foreach(Employee employee in _employees)
            {
                printEmployee(employee);
            }
        }

        private void printEmployee(Employee employee)
        {
            Console.WriteLine($"{employee.fullName} works for {_name} as {employee.getTitle()} since {employee.getStartDate()}");
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }
    }
}