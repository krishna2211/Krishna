using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDEMOS
{
    class LinqExample3
    {
        public static void Main()
        {
            var anonym = new { Name = "Anonymous", Surname = "Very anonymous", Age = "18" };
            Console.WriteLine(anonym.Name);
            Console.WriteLine(anonym.Surname);
            Console.WriteLine(anonym.Age);
            Console.WriteLine("---------------------");

            List<User> users = new List<User>();

            //var query = from u in users
            //            where (u.Age > 15)
            //            orderby u.FirstName
            //            select u.Age;

            //foreach (int age in query)
            //{
            //    Console.WriteLine(age);
            //}

            Console.WriteLine("---------------------");
            int[] numbers = { 3, 5, 8, 5, 9, 1, 3, 4 };

            var query1 = from n in numbers
                         where (n > 5)
                         select n;

            foreach (int number in query1)
                Console.WriteLine(number);
            Console.WriteLine("---------------------");
            string[] words = { "SOcial", "nEtwork", "ICT" };

            var query2 = from w in words
                         select w.ToLower();

            foreach (string word in query2)
                Console.WriteLine(word);
            Console.WriteLine("---------------------");

            var query3 = numbers.Take(3);

            foreach (int number in query3)
                Console.WriteLine(number);
            Console.WriteLine("---------------------");

            var query4 = numbers.Skip(5);

            foreach (int number in query4)
                Console.WriteLine(number);
            Console.WriteLine("---------------------");

            var query5 = numbers.Distinct();

            foreach (int number in query5)
                Console.WriteLine(number);
            Console.WriteLine("---------------------");

            int[] set1 = { 3, 5, 8, 5, 9, 1, 3, 4 };
            int[] set2 = { 3, 7, 2, 1, 4 };

            var query6 = set1.Union(set2);

            foreach (int number in query6)
                Console.WriteLine(number);
            Console.WriteLine("---------------------");
            var query7 = set1.Except(set2);

            foreach (int number in query7)
                Console.WriteLine(number);
           // string[] Birds = { "Indigo Bunting", "Rose Breasted Grosbeak", "Robin", "House Finch", "Gold Finch", "Ruby Throated Hummingbird", "Rufous Hummingbird", "Downy Woodpecker" };

            string[] Birds = { "Indigo Bunting", "Rose Breasted Grosbeak", "Robin", "House Finch", "Gold Finch", "Ruby Throated Hummingbird", "Rufous Hummingbird", "Downy Woodpecker" };
            var query = from n in Birds
                        where n.StartsWith("R")
                        select n;
            foreach (string s in query1)
            {
                Console.WriteLine(s);
            }




            Console.ReadLine();
        }
    }
}
    
        class User
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public User(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }

            public override string ToString()
            {
                return String.Format("{0} {1}, {2} years old", FirstName, LastName, Age);
            }
        }
    

