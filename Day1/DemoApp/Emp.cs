using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace DemoApp
{
   public class Emp
    {
        public int empno { get; set; }
        public string ename { get; set; }
        public string desig { get; set; }
    }
    public class EmpData
    {
        public static void Main()
        {
            Emp eobj = new Emp { empno = 100, desig = "Developer", ename = "Amit" };
            Emp eobj1 = new Emp { empno = 200, desig = "tester", ename = "Anil" };
            Emp eobj2 = new Emp { empno = 300, desig = "Manager", ename = "Arun" };
            Emp eobj3 = new Emp { empno = 400, desig = "Developer", ename = "Asha" };
            Emp eobj4 = new Emp { empno = 500, desig = "tester", ename = "Akash" };
            Emp eobj5 = new Emp { empno = 600, desig = "tester", ename = "Anu" };
            Emp eobj6 = new Emp { empno = 700, desig = "Manager", ename = "Anuja" };
            ArrayList aobj = new ArrayList();
            aobj.Add(eobj);
            aobj.Add(eobj1);
            aobj.Add(eobj2);
            aobj.Add(eobj3);
            aobj.Add(eobj4);
            aobj.Add(eobj5);
            Hashtable hobj = new Hashtable();
            hobj.Add("Emp", aobj);
            foreach(Emp e in hobj.Keys)
            {
                Console.WriteLine(e.desig);
            }
            Console.ReadLine();
        }
    }

}
