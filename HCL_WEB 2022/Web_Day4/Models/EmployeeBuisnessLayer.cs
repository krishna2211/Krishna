using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Day4.Models
{
    public class EmployeeBuisnessLayer
    {
        public Employee GetEmployeeDetails(int EmployeeId)
        {
            Employee eobj = new Employee
            {
                EmployeeId = EmployeeId,
                Name = "Ajit",
                Address = "Mumbai",
                City = "Andheri",
                Gender = "Male",
                Salary = 78000.32
            };
            return eobj;
        }
    }
}