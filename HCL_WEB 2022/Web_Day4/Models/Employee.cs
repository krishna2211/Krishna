using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Day4.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        
        public string Name { get; set; }
        
        public string Address { get; set; }
        
        public string City{ get; set; }

        public string Gender { get; set; }

        public double Salary { get; set; }
    }
}