using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    interface IEmployee
    {
        int EmployeeID { get; set; }
        string FullName { get; set; }
    }
}
