using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeManagement
{
    class Company : Employee
    {
        List<Employee> EmployeeList = new List<Employee>();

        public int AddEmployee(IEmployee e, out int id)
        {
            int i = 1;
            Random random = new Random();
            int rnd = random.Next(1152);

            EmployeeList.Add(new Employee(rnd, e.FullName));
            Console.WriteLine();

            foreach (var employee in EmployeeList)
            {
                Console.WriteLine("********* Employee " + i + " *********");
                Console.WriteLine("Employee ID: " + employee.EmployeeID);
                Console.WriteLine("Name: " + employee.FullName);
                Console.WriteLine();
                i++;

            }

            id = rnd;
            return rnd;
        }

        public IEmployee GetEmployees()
        {
            int i = 1;
            Console.WriteLine();

            foreach (var employee in EmployeeList)
            {
                Console.WriteLine("********* Employee " + i + " *********");
                Console.WriteLine("Employee ID: " + employee.EmployeeID);
                Console.WriteLine("Name: " + employee.FullName);
                Console.WriteLine();
                i++;
            }

            return null;
        }

    }
}
