using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    interface ICompany
    {
        public int AddEmployee(IEmployee e, out int id);
    }
}