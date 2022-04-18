using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    class Employee : IEmployee
    {
        private int _employeeID;
        private string _fullName;

        public Employee()
        {
            EmployeeID = 0;
            FullName = null;
        }
        public Employee(int employeeID, string fullName)
        {
            EmployeeID = employeeID;
            FullName = fullName;

        }

        public int EmployeeID { get => _employeeID; set => _employeeID = value; }
        public string FullName { get => _fullName; set => _fullName = value; }

    }
}
