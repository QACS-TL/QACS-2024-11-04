using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LoopsAndCollections
{
    internal class LoopsCollections
    {
        public static void ArrayInitialisation()
        {
            Console.WriteLine("Array Initialisation");

            int[] arr3 = { 2, 4, 6, 8 }; // array initializer
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            Car[] cars = { new Car(), new Car(), new Car() };

            // Implicitly typed arrays
            var a = new[] { 1, 10, 100, 1000 }; // int[]
            var b = new[] { "hello", null, "world" }; //string[]

            // must use 'new' when declaring and initializing separately
            int[] arr4;
            arr4 = new int[] { 1, 3, 5, 7, 9 }; //OK
            //arr4 = {1, 3, 5, 7, 9}; //Error
            int[] arr5;
            arr5 = new[] { 1, 3, 5, 7, 9 }; //OK
        }

        public static void LoopingThroughArrays()
        {
            Console.WriteLine("\nLooping Through Arrays:");

            int[] array6 = { 1, 1, 2, 3, 5, 8, 13, 21 };
            foreach (int i in array6)
            {
                Console.WriteLine(i * 2); // 2 2 4 6 10 16, 26, 42
            }
            string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            foreach (string day in weekDays)
            {
                Console.WriteLine(day); // Sun Mon Tue Wed Thu Fri Sat
            }


            Coords[] coordinates = { new Coords(10, 20), new Coords(8, 3), new Coords(5, 5) };
            foreach (Coords coord in coordinates)
            {
                Console.WriteLine($"X is {coord.X}, Y is {coord.Y}");
            }
            // X is 10 and Y is 20
            // X is 8 and Y is 3
            // X is 5 and Y is 5
        }

        public static void ForEachLoops()
        {
            Console.WriteLine("\nForEach Loops:");

            Coords[] coordinates = { new Coords(10, 20), new Coords(8, 3), new Coords(5, 5) };
            // use var to let the compiler infer the type of the iteration variable
            foreach (var coord in coordinates)
            {
                Console.WriteLine(coord.GetType()); //Coords
                Console.WriteLine($"X is {coord.X} and Y is {coord.Y}");
            }

            //use var to let the compiler infer the type of the iteration varia
            foreach (var coord in coordinates)
            {
                Console.WriteLine(coord.GetType());
                Console.WriteLine($"X is {coord.X} and Y is {coord.Y}");
                //coord.X++ ;
                //coord.Y--;
            }
        }

        public static void ForLoops()
        {
            Console.WriteLine("\nFor Loops:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(i);
            }
            //output:
            //01234

            Console.WriteLine();
            // decrement iterator
            int x;
            for (x = 10; x >= 5; x--)
            {
                Console.Write($"{x} ");
            }
            // Output:
            // 10 9 8 7 6 5

            Console.WriteLine();
            // iterator using compound assignment
            for (int i = 0; i <= 10; i += 2)
            {
                Console.Write($"{i} ");
            }
            // Output :
            // 0 2 4 6 8 10

            Console.WriteLine();
            // multiple loop variables
            for (int i = 0, j = 0; i + j < 5; i++, j++)
            {
                Console.WriteLine($"Value of i: {i}, j: {j}");
            }
            // Value of i: 0, j: 0
            // Value of i: 1, j: 1
            // Value of i: 2, j: 2

            Console.WriteLine();
            //nested for loops
            for (int i = 0; i < 2; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    Console.WriteLine($"Value of i: {i}, j: {j}");
                }
            }
            // Value of i: 0, j: 0
            // Value of i: 0, j: 1
            // Value of i: 0, j: 2
            // Value of i: 0, j: 3
            // Value of i: 1, j: 1
            // Value of i: 1, j: 2
            // Value of i: 1, j: 3

            Console.WriteLine();
            //Jump Statements
            // break to conditionally exit out of the loop early
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    break;

                Console.Write($"{i} ");
            }// 0 1 2 3 4

            Console.WriteLine();
            // continue to conditionally jump to the top of the loop
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;
                Console.Write($"{i} ");
            }// 0 1 2 3 4 6 7 8 9 

            Console.WriteLine();
            //nested for loops with goto
            for (int i = 0; i < 2; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    if (j == 3)
                    {
                        goto pickupPoint;
                    }
                    Console.WriteLine($"Value of i: {i}, j: {j}");
                }
            }
        pickupPoint:
            Console.WriteLine("Code continues here after GOTO");

            // Output:
            // Value of i: 0, j: 0
            // Value of i: 0, j: 1
            // Value of i: 0, j: 2
            // Code continues here after GOTO

        }

        public static void WhileLoops()
        {
            Console.WriteLine("\nWhile Loops:");

            // initialization
            int n = 10;
            while (n < 5) // Boolean expression
            {
                Console.WriteLine($"{n} ");
                n++; // increment
            }
            // 0 1 2 3 4 

            Console.WriteLine();
            // equivalent of a 'for' loop
            int i = 0;
            while (true)
            {
                Console.Write($"{i} ");

                i++;

                if (i > 5)
                    break;
            }
            // 0 1 2 3 4 5

            Console.WriteLine("\n");
            // nested while loops
            i = 0;
            int j = 1;
            while (i < 2)
            {
                Console.WriteLine($"i = {i}");
                i++;
                while (j < 2)
                {
                    Console.WriteLine($"j = {j}");
                    j++;
                }
            }
            // i = 0
            // j = 1
            // i = 1
        }

        public static void DoLoops()
        {
            Console.WriteLine("\nDo Loops:");

            int i = 10; // initialisation
            do
            {
                Console.WriteLine($"{i} ");
                i++; // increment
            } while (i < 5); //Boolean expression
            // 0 1 2 3 4

            Console.WriteLine();
            // do loop with break
            i = 0;
            do
            {
                Console.Write($"{i} ");
                i++;

                if (i > 5)
                    break;
            } while (i < 10);
            // 0 1 2 3 4 5

            Console.WriteLine("\n");
            // nested do while
            int a = 0;
            do
            {
                Console.WriteLine($"a = {a} ");
                int b = a;
                a++;
                do
                {
                    Console.WriteLine($"b = {b} ");
                    b++;
                } while (b < 2);
            } while (a < 2);
            // a = 0
            // b = 0
            // b = 1
            // a = 1
            // b = 1
        }

        public static void GenericLists()
        {
            Console.WriteLine("\nGeneric Lists:");

            List<string> olympicCities = new() { "Sydney", "Athens", "Beijing", "London", "Rio" };
            olympicCities.Add("Tokyo");

            // access an object by index
            string city2012 = olympicCities[3];
            Console.WriteLine(city2012); //London

            olympicCities.Insert(2, "Bognor");

            foreach (var city in olympicCities)
            {
                Console.Write($"{city} ");
            }
            // Sydney Athens Bognor Beijing London Rio Tokyo

            Console.WriteLine();
            List<string> upcomingCities = new() { "Paris", "Los Angeles", "Brisbane" };
            // search the list and add a range of
            if (!olympicCities.Contains("Paris"))
            {
                olympicCities.AddRange(upcomingCities);
            }

            // search and remove an object from the list
            int bognorIndex = olympicCities.IndexOf("Bognor");
            Console.WriteLine($"Bognor is at index position {bognorIndex}");
            // Bognor is at index position 2

            olympicCities.Remove("Bognor");

            bognorIndex = olympicCities.IndexOf("Bognor");
            Console.WriteLine($"Bognor is at index position {bognorIndex}");
            // Bognor is at index position -1

            // sort the list of strings using the default comparer
            olympicCities.Sort();

            foreach (var city in olympicCities)
            {
                Console.Write($"{city} ");
            }
            // Athens Beijing Brisbane London Los Angeles Paris Rio Sydney Tokyo
        }

        public static void Dictionaries()
        {
            Console.WriteLine("\nDictionaries:");

            Dictionary<string, int> cities = new()
            {
                ["Sydney"] = 4_992_000,
                ["Athens"] = 3_167_000,
                ["Beijing"] = 21_540_000
            };

            int population = cities["Athens"]; //cities is indexed by the key name
            Console.WriteLine($"Population of Athens is {population}");
            // Population of Athens is 3167069

            Console.WriteLine();
            foreach (KeyValuePair<string, int> kvp in cities)
            {
                string citykey = kvp.Key;
                int populationValue = kvp.Value;
                Console.WriteLine($"City {citykey} has a population of {populationValue}");
            }
            //City Sydney has a population of 4992000
            //City Athens has a population of 3167900
            //City Beijing has a population of 21540000

            Console.WriteLine();
            // iterate over the keys
            foreach (string cityKey in cities.Keys)
            {
                Console.Write($"{cityKey} {cities[cityKey]} \t");
            }
            // Sydney Athens Beijing

            Console.WriteLine();
            // iterate over the values
            foreach (int populationValue in cities.Values)
            {
                Console.Write($"{populationValue} ");
            }
            // 4992660 3167060 21540000

            Console.WriteLine();
            // iterate over the keyvalue pairs
            foreach (KeyValuePair<string, int> kvp in cities)
            {
                Console.WriteLine(kvp.ToString());
            }
            //[Sydney, 4992000]
            //[Athens, 3167000]
            //[Beijing, 21540000]

            Console.WriteLine();
            // add objects to a dictionary
            cities.Add("London", 8_982_000);
            //cities.Add("London", 9_982_000); // Will trigger an error

            // lookup a value using the key
            int populationLondon = cities["London"];
            Console.WriteLine(populationLondon);

            if (cities.ContainsKey("Rio"))
            {
                Console.WriteLine(cities["Rio"]);
            }

            Console.WriteLine();
            // update a value
            cities["London"] = 9_000_000;
            // iterate over the keyvalue pairs
            foreach (KeyValuePair<string, int> kvp in cities)
            {
                Console.WriteLine(kvp.ToString());
            }
            //[Sydney, 4992000]
            //[Athens, 3167600]
            //[Beijing, 21540000]
            //[London, 9009000]

            //remove an object
            cities.Remove("London");

            Console.WriteLine();
            // iterate over the keys
            foreach (string cityKey in cities.Keys)
            {
                Console.WriteLine($"{cityKey} ");
            }
            // Sydney Athens Beijing
        }

        public static void StrongTyping()
        {
            Console.WriteLine("\nStrongly Typed:");

            // Generics are strongly—typed
            List<string> olympicCities = new();
            olympicCities.Add("Tokyo"); // <string> 0k
            //olympicCities.Add(true); //<bool> compile error
            //olympicCities.Add(1234); // < int > compile error

            Dictionary<string, int> cities = new();
            cities.Add("London", 8_982_090); // <string, int> 0K
            //cities.Add(8_982_090, "London"); // <int, string> compile error
            //cities.Add("Paris", "2_140_000"); // <string, string> compile error
        }

        public static void IndexerAccessOperator()
        {
            Console.WriteLine("\nIndexer Access Operator:");

            // indexer access operator
            string[] drinks = {"Water", "Coffee", "Tea", "Orange Juice" };
            Console.WriteLine($"The zeroth drink is {drinks[0]}"); //Water
            Console.WriteLine($"The last drink is {drinks[3]}"); // Orange Juice

            List<string> snacks = new() { "Apple", "Crisps", "Biscuits" };
            Console.WriteLine($"The zeroth snack is {snacks[0]}"); // Apple
            Console.WriteLine($"The last snack is {snacks[2]}"); //Biscuits

            Dictionary<string, int> foodCalories = new()
            {
                ["Banana"] = 89,
                ["Chocolate Digestive"] = 84
            };
            Console.WriteLine($"Calories in a banana = {foodCalories["Banana"]}");
            // Calories in a banana = 84

            Console.WriteLine();
            List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            // index from end operator
            var firstFromEnd_10 = numbers[^1];
            var thirdFromEnd_8 = numbers[^3];

            // range operator
            var slice_345678910 = numbers.ToArray()[2..];
            var slice_12345678910 = numbers.ToArray()[..];

            // range and index from end operators
            var slice_34567 = numbers.ToArray()[2..^3];
            var slice_1234567 = numbers.ToArray()[..^3];

            Console.WriteLine($"First from end: {firstFromEnd_10}");
            Console.WriteLine($"Third from end: {thirdFromEnd_8}");
            Console.Write($"\nSlice third to end: ");
            slice_345678910.ToList().ForEach(n => Console.Write($"{n} "));
            Console.Write($"\nSlice all numbers: ");
            slice_12345678910.ToList().ForEach(n => Console.Write($"{n} "));
            Console.Write($"\nSlice third to three from end: ");
            slice_34567.ToList().ForEach(n => Console.Write($"{n} "));
            Console.Write($"\nSlice first to three from end: ");
            slice_1234567.ToList().ForEach(n => Console.Write($"{n} "));
        }
    }
}

