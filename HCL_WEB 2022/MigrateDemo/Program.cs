using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CarContext())
            {
                //Insert values in database  
                context.Cars.Add(new Car { CarModel = "ford", modelNo = 100 });
                context.Cars.Add(new Car { CarModel = "Honda", modelNo = 200 });
                context.SaveChanges();

                //Get all values from database  
                foreach (var c in context.Cars)
                {
                    Console.WriteLine("ModelNo : " + c.modelNo);
                    Console.WriteLine("Car Model Name : " + c.CarModel);
                }
            }

            Console.WriteLine("Press Any key to exit....");
            Console.ReadKey();
        }
    }
}
