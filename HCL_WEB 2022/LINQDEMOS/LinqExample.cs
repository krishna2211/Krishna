using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDEMOS
{
    class LinqExample
    {
        public static void Main()
        {
            string[] languages = {"java", "C#", "C++", "python", "smallTalk", "pascal"};
            var list = from l in languages
                       select l;
            foreach (string s in list)
             {
               Console.WriteLine("The records are" + "   " + s);
            }
            Console.WriteLine("------------------------------------------");
            var result = from b in languages
                         where b.StartsWith("p")
                         select b;
            foreach (string s in result)
            {
               Console.WriteLine("The records are" + "   " + s);
            }
            Console.WriteLine("------------------------------------------");
            var result1 = from l in languages
                          where l=="C#"
                          select l;
            foreach (string s in result1)
            {
                Console.WriteLine("The records are" + "   " + s);
            }
            Console.WriteLine("------------------------------------------");
            var result2 = from l in languages
                         orderby l descending
                         select l;
            foreach (string s in result2)
            {
                Console.WriteLine("The records are" + "   " + s);
            }
            Console.ReadLine();
        }
    }
}
