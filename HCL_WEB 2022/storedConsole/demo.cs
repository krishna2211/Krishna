using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storedConsole
{
    class demo
    {
        public static void Main()
        {
            using (var context = new febDemoEntities())
            {
                emp eobj  = new emp() { empno=300,ename="Radha",desig="Manager",salary=78000 };

                context.emps.Add(eobj);
                //will execute sp_InsertStudentInfo 
                context.SaveChanges();

                eobj.ename = "Arun";
                //will execute sp_UpdateStudent
                context.SaveChanges();

                context.emps.Remove(eobj);
                //will execute sp_DeleteStudentInfo 
                context.SaveChanges();
                Console.WriteLine("done");
                Console.ReadLine();
            }
        }
    }
}
