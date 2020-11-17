using System;

namespace classes
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private string _title;
        private DateTime _startDate;

        public string fullName 
        {
            get
            {
                return $"{_firstName} {_lastName}";
            }
        }

        public Employee(string firstName, string lastName, string title)
        {
            _firstName = firstName;
            _lastName = lastName;
            _title = title;
            _startDate = DateTime.Now;
        }

        public string getTitle()
        {
            return _title;
        }

        public DateTime getStartDate()
        {
            return _startDate;
        }
    }
}