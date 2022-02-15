using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDEMOS
{
    class LinqExample2
    {
        public static void Main()
        {
            List<Employee> objEmp = new List<Employee>()
            {
               new Employee { EmpId=1,Name = "Amit", Location="Chennai" },
               new Employee { EmpId=2,Name = "Bhaskar", Location="Chennai" },
               new Employee { EmpId=3,Name = "Praveen Alavala", Location="Guntur" },
               new Employee { EmpId=4,Name = "Sateesh Alavala", Location ="Vizag"},
               };
            var result = from e in objEmp
            where e.Location.Equals("Chennai")
            select new
            {
              Name = e.Name,
              Location = e.Location
             };
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + "\t | " + item.Location);
            }
            Console.WriteLine("-----------------------------------");

            var result1 = from e in objEmp
                          select e;

            foreach (var item in result1)
            {
                Console.WriteLine(item.Name + "\t | " + item.Location);
            }
            Console.WriteLine("-----------------------------------");

           var result2= objEmp.Where(p => p.Location == "Vizag");
            foreach (var item in result2)
            {
                Console.WriteLine(item.Location);
            }
            Console.WriteLine("-----------------------------------");
            var result3 = objEmp.OrderByDescending(x => x.Name);

            foreach (var d in objEmp)

            {

                Console.WriteLine(d.Name);

            }
            Console.ReadLine();
        }
    }
    class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
   }
}
