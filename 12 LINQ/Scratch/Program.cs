using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace Scratch
{
    class Program
    {
        static void Main(string[] args)
        {

            //Non LINQ Example

            //Specify the data source
            int[] scores = { 97, 92, 81, 60 };
            //Create a List to store the high scores
            List<int> highscores = new List<int>();

            //Iterate over the array to find the
            //scores above 80 and add to the list
            foreach(int score in scores)
            {
                if (score > 80)
                {
                    highscores.Add(score);
                }
            }

            //Iterate over the highestScores List
            foreach(int i in highscores)
            {
                Console.Write(i + " ");
            }
            //output 97 92 81

            Console.Write("\n\n");

            //LINQ
            IEnumerable<int> scoreQuery = from score in scores
                                          where score > 80
                                          select score;

            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            //output 97 92 81
            Console.Write("\n\n");

            //Define Query using Method Syntax
            var squery = scores.Where(s => s > 80).OrderBy(s => s).Select(s => s);

            foreach (int i in squery)
            {
                Console.Write(i + " ");
            }
            //output 97 92 81
            Console.Write("\n\n");


            //Deferred Execution
            string[] names = {"Tommy","Fred","Rashid","Bobby"};

            IEnumerable<string> query = (from s in names
                                        where s.Length == 5
                                        select s);
            foreach (string s in query)
            {

                Console.WriteLine(s);

            }

            names[0] = "Susie";

            foreach (string s in query)
            {

                Console.WriteLine(s);
            }
            Console.Write("\n\n");

            //JOINS
            string[] firstNames = { "Vinita", "Pete" };

            var people = new List<Person>
            {
                new Person("Pete", 20),
                new Person("Rafael", 50),
                new Person("Vinita", 32),
                new Person("Pete", 37),
                new Person("Tom", 40)
            };

            var matchingPeople = from n in firstNames
                                 join p in people
                                 on n equals p.Name
                                 select p;

            foreach(var p in matchingPeople)
            {
                Console.WriteLine($"{p.Name} {p.Age}");
            }
            Console.Write("\n\n");

            //Group Joins
            var groupJoined = from n in firstNames
                                 join p in people
                                 on n equals p.Name into matchingNames
                                 select new {Name = n, Persons = matchingNames };

            foreach (var group in groupJoined)
            {
                Console.WriteLine(group.Name);
                foreach(Person p in group.Persons)
                {
                    Console.WriteLine($"...{p.Age}");
                }
                
            }
            Console.Write("\n\n");

            //Aggregations
            List<Customer> customers = new List<Customer>
            {
                new Customer(){Name="Ted", AccountNumber="1111111", City="London", Balance=1000.00M},
                new Customer(){Name="Juanita", AccountNumber="2222222", City="Paris", Balance=2000.00M},
                new Customer(){Name="Sadia", AccountNumber="3333333", City="London", Balance=3000.00M},
                new Customer(){Name="Angel", AccountNumber="4444444", City="Brighton", Balance=4000.00M},
                new Customer(){Name="Crystal", AccountNumber="5555555", City="London", Balance=5000.00M}
            };

            var baseQuery = from c in customers
                            where c.City == "London"
                            orderby c.Balance
                            select c;

            decimal avg = baseQuery.Average(c => c.Balance);
            decimal max = baseQuery.Max(c => c.Balance);
            decimal total = baseQuery.Sum(c => c.Balance);

            Console.WriteLine($"Avg: {avg}, Max: {max}, Tot: {total}");

            IEnumerable<decimal> qry2 = from c in customers
                            where c.City == "London"
                            orderby c.Balance
                            select c.Balance;

            avg = qry2.Average();
            max = qry2.Max();
            total = qry2.Sum();

            Console.WriteLine($"Avg: {avg}, Max: {max}, Tot: {total}");
            Console.Write("\n\n");

            //Let
            string[] strings =
            {
                "Been there, done that.",
                "All Greek to me.",
                "A piece of cake."
            };

            //Split the sentence into an array of words
            //and select those whose first letter is a vowel.
            var qry3 =
                from sentence in strings
                let words = sentence.Split(' ')
                from word in words
                let w = word.ToLower()
                where w[0] == 'a' || w[0] == 'e' || w[0] == 'i' || w[0] == 'o' || w[0] == 'u'
                select word;

            //execute the query
            foreach(var v in qry3)
            {
                Console.WriteLine($"\"{v}\" starts with a vowel");
            }
            Console.Write("\n\n");

            //OfType
            List<Mammal> mammals = new()
            {
                new Dog() {Name="Rover"},
                new Cat() {Name="Tiddles"},
                new Dog() {Name="Snowy"}
            };

            var dogs = mammals.OfType<Dog>();

            foreach(var dog in dogs)
            {
                Console.WriteLine(dog.Name);
            }

        }
    }
}
