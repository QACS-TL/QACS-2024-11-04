using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndTypes
{
    internal class DataTypes
    {
        public static void BoolDataTypes()
        {
            Console.WriteLine("Bool Data Types:");
            Console.WriteLine(7.0 < 5.1); // output: False
            Console.WriteLine(5.1 > 5.1); // output: False
            Console.WriteLine(5.1 >= 5.1); // output: True
            Console.WriteLine(3.4 == 3.4); // output: True
            Console.WriteLine(3.4 != 3.4); // output: False
            Console.WriteLine(double.NaN < 7.0); // output: False
        }

        public static void CharDataTypes()
        {
            Console.WriteLine("Char Data Types:");
            char letter = 'p';
            char copyrightUni = '\u00a9';
            char copyrightHex = '\xa9';
            char atSymbol = '\x40';

            Console.WriteLine(letter);
            Console.WriteLine(copyrightUni);
            Console.WriteLine(copyrightHex);
            Console.WriteLine(atSymbol);
        }

        public static void NullableDataTypes()
        {
            Console.WriteLine("Nullable Types:");
            bool? check = true;
            bool? isValid = false;
            bool? flag = null;
            Console.WriteLine(check);
            Console.WriteLine(isValid);
            Console.WriteLine(flag);

            //If flag is set to a null print "NULL" else
            //print the content of flag.
            Console.WriteLine(flag is null ? "NULL" : flag);

            double? pi = 3.14159;
            char? letter = 'p';
            int luckyNumber = 7;
            int? myLuckyNumber = luckyNumber;
            Console.WriteLine(pi);
            Console.WriteLine(letter);
            Console.WriteLine(luckyNumber);
            Console.WriteLine(myLuckyNumber);

            Nullable<int> myInt = null;
            Console.WriteLine(myInt is null ? "NULL" : myInt);
        }
        public static void StructDataTypes()
        {
            Console.WriteLine("Structs:");
            Coords c1 = new Coords(5, 7);
            Coords c2 = new(5, 7);
            Console.WriteLine(c1.X);
            Console.WriteLine(c2.Y);
             //c1.X = 10; // compile error because X is readonly

            //By default ToString() returns the namespace and type
            //of the variable. It can be overriden to return something
            //more useful.
            Console.WriteLine(c2.ToString());
        }

        public static void EnumDataTypes()
        {
            Console.WriteLine("Enums:");
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);

            FiscalMonths firstMonth = FiscalMonths.April;
            Console.WriteLine(firstMonth);
        }

        public static void StringDataTypes()
        {
            Console.WriteLine("String Types:");
            string greeting = "good morning";
            string message = "good ";
            message = message + "morning";



            Console.WriteLine(greeting == message);
            Console.WriteLine(object.ReferenceEquals(greeting, message));

            //String Literals
            string literalString = "This is a string literal";
            string verbatimString = @"This is a verbatim string and can contain special characters such as \ and \n";
            string newLine = "\n";
            string name = "Bart";
            int age = 8;
            string concatentatedString = "My name is " + name + " and I am " + age + " years old";
            string formatstring = string.Format("My name is {0} and I am {1} years old", name, age.ToString());
            string interpolatedString = $"My name is {name} and I am {age} years old";

            Console.WriteLine(literalString);
            Console.WriteLine(verbatimString);
            Console.WriteLine(concatentatedString);
            Console.WriteLine(formatstring);
            Console.WriteLine(interpolatedString);
        }

        public static void ClassDataTypes()
        {
            Console.WriteLine("Classes:");
            Car julieCar = new Car();
            julieCar.Register("Julie Dooley", "1 Main Street", "CH12 9DL", "UK");

            Car lisaCar = new Car();
            lisaCar.Register("Lisa Simpson", "742 Evergreen Terrace", "97394", "USA");

            Console.WriteLine($"{julieCar.Name}'s car has been successfully registered at {julieCar.Address}, {julieCar.PostCode}, {julieCar.Country}.");
            Console.WriteLine($"{lisaCar.Name}'s car has been successfully registered at {lisaCar.Address}, {lisaCar.PostCode}, {lisaCar.Country}.");

        }

        public static void CreatingSimpleTypes()
        {
            Console.WriteLine("Creating Simple Types:");
            int a = 6; // literal assignment
            float b = 7.5F; // literal assignment with a suffix
            decimal c = 9.99M; // M or m suffix denotes a decimal literal
            bool d = false; // assign special value false (or true) to a bool
            char e = 'a'; // single quotes for char literals
            char? h = null; // ? for a nutable variable
            string f = "hello"; // string is a reference type but gets created like a value type
            string? g = null; // nullable string

            //The var keyword
            int x = 3;
            var y = 9;
            Console.WriteLine(x.GetType()); // System. Int32
            Console.WriteLine(y.GetType()); // System. Int32
        }

        public static void CreatingNonSimpleTypes()
        {
            Console.WriteLine("Creating Non-Simple Types:");
            int a = 4;
            int b = 6;

            Level level = Level.High;// enum variable is constrained to the defined values
            Coords c1 = new Coords(b, a); // a struct can be instantiated using 'new'
            Console.WriteLine(c1.GetType());// GetType method gets the type of the current instance

            var c2 = new Coords(b, a); // the type can be inferred by the compiler when using 'var'
            Console.WriteLine(c2.GetType());

            Coords c3 = new(b, a); // C# 9 target-typed constructor invocation syntax
            Console.WriteLine(c3.GetType()); // cl, c2 and c3 are all of type Coords
        }

        public static void CreatingReferenceTypes()
        {
            Console.WriteLine("Reference Types:");
            Car carl = new Car(); // reference types are instantiated using 'new'
            var car2 = new Car(); // the type can be inferred by the compiler
            Car car3 = new(); // C# 9 target—typed constructor invocation syntax

            Console.WriteLine(car3.GetType());
            // 'if' is a conditional statement with the condition to be evaluated in brackets
            if (car3 is Car)
            {
                // The 'is' operator checks if the result of an expression is compatible with a given ty
                Console.WriteLine(nameof(car3) + " is a Car instance");
                // nameof produces the name of a variable, type, or member as a string constant
            }



        }

        public static void ArithmeticPreAndPostFixOperatorExamples()
        {
            Console.WriteLine("Pre and Post Fix Operators:");
            // post—fix increment operator
            int i = 3;
            Console.WriteLine(i); // output: 3
            Console.WriteLine(i++); // output: 3
            Console.WriteLine(i); // output: 4

            // pre—fix increment operator
            double a = 1.5;
            Console.WriteLine(a);  // output: 1.5
            Console.WriteLine(++a);  // output: 2.5
            Console.WriteLine(a);  // output: 2.5

            // post—fix decrement operator
            i = 3;
            Console.WriteLine(i); // output: 3
            Console.WriteLine(i--); // output: 3
            Console.WriteLine(i); // output: 2

            // pre—fix decrement operator
            a = 1.5;
            Console.WriteLine(a); // output: 1.5
            Console.WriteLine(--a); // output: 0.5
            Console.WriteLine(a); // output: 0.5
        }

        public static void UnaryOperatorExamples()
        {
            Console.WriteLine("Unary Operators:");
            // unary plus and minus operators
            Console.WriteLine(+8); // output: 8
            Console.WriteLine(-8); // output: -8
            Console.WriteLine(-(-8)); // output: 8

            uint a = 9;
            var b = -a;
            Console.WriteLine(b); // output: -9
            Console.WriteLine(b.GetType()); // output: System.Int64

            Console.WriteLine(-double.NaN); // output: NaN
        }

        public static void AddAndSubtractOperatorExamples()
        {
            Console.WriteLine("Addition and Subtraction Operators:");
            // addition operator
            Console.WriteLine(5 + 4); // output: 9
            Console.WriteLine(5 + 4.3); // output: 9.3
            Console.WriteLine(5.1m + 4.2m); // output: 9.3
            // subtraction operator
            Console.WriteLine(47 - 3);  // output: 44 
            Console.WriteLine(5 - 4.3);  // output: 0.7000000000000002
            Console.WriteLine(7.5m - 2.3m);  // output: 5.2

            Console.WriteLine(Math.Round(5 - 4.3, 2));  // output: 0.7
        }

        public static void MultiplyAndDivideOperatorExamples()
        {
            Console.WriteLine("Multiply and Divide Operators:");
            // multiply operator
            Console.WriteLine(5 * 2);        // output: 10
            Console.WriteLine(0.5 * 2.5);    // output: 1.25
            Console.WriteLine(0.1m * 23.4m); // output: 2.34

            // division operator
            // For integer operands, the result is an int type
            // rounded towards zero
            Console.WriteLine(13 / 5);   // output: 2
            Console.WriteLine(-13 / 5);  // output: -2
            Console.WriteLine(13 / -5);  // output: -2
            Console.WriteLine(-13 / -5); // output: 2

            // int / double
            Console.WriteLine(13 / 5.0); // output: 2.6

            int a = 13;
            int b = 5;
            Console.WriteLine((double)a / b); // output: 2.6

            Console.WriteLine(16.8f / 4.1f); // output : 4.097561
            Console.WriteLine(16.8d / 4.1d); // output : 4.09756097566976
            Console.WriteLine(16.8m / 4.1m); // output : 4.0975609756697560975609756098
        }

        public static void RemainderOperatorExamples()
        {
            Console.WriteLine("Remainder Operators:");
            // modulus / remainder operator
            Console.WriteLine(5 % 4); // output: 1
            Console.WriteLine(5 % -4); // output: 1
            Console.WriteLine(-5 % 4); // output: -1
            Console.WriteLine(-5 % -4); // output: -1

            Console.WriteLine(-5.2f % 2.0f); // output: -1.1999998
            Console.WriteLine(5.9 % 3.1); // output: 2.8000000000000003
            Console.WriteLine(5.9m % 3.1m); // output: 2.8

            Console.WriteLine(Math.Round(-5.2f % 2.0f, 2)); // output: -1.2
            Console.WriteLine(Math.Round(5.9 % 3.1, 2)); // output: 2.8
        }
        public static void OperatorPrecedence()
        {
            Console.WriteLine("Operator Precedence:");
            double a = 3;
            double b = 5;
            double c = 7;
            double d = a + b * c;
            Console.WriteLine($"d contains {d}");

            double e = (a + b) * c;
            Console.WriteLine($"e contains {e}");
        }

        public static void ComparisonOperators()
        {
            Console.WriteLine("Comparison Operators:");
            // less than <
            Console.WriteLine(7.0 < 5.1); // output: False
            Console.WriteLine(5.1 < 5.1); // output: False
            Console.WriteLine(0.0 < 5.1); // output: True

            // greater than >
            Console.WriteLine(7.0 > 5.1); // output: True
            Console.WriteLine(5.1 > 5.1); // output: False

            //less than or equal <= 
            Console.WriteLine(7.0 <= 5.1); // output: False
            Console.WriteLine(5.1 <= 5.1); // output: True
            //greater than or equal >= 
            Console.WriteLine(7.0 >= 5.1); // output: True
            Console.WriteLine(5.1 >= 5.1); // output: True

            // NaN
            Console.WriteLine(double.NaN >= 5.1); // output: False
            Console.WriteLine(double.NaN >= 5.1); // output: False

            //char comparison
            char a = 'a';
            char b = 'b';
            Console.WriteLine(a > b); // output: False
            Console.WriteLine(a <= b); // output: True

            // enum comparison
            Level low = Level.Low;
            Level high = Level.High;
            Console.WriteLine(low > high); // output: False
            Console.WriteLine(low < high); // output: True
        }

        public static void LogicalOperators()
        {
            Console.WriteLine("Logical Operators:");
            // logical negation
            bool passed = false;
            Console.WriteLine(!passed); // output: True
            Console.WriteLine(!true); // output: False

            // logical exclusive OR
            Console.WriteLine(true ^ true); // output: False
            Console.WriteLine(true ^ false); // output: True
            Console.WriteLine(false ^ true); // output: True
            Console.WriteLine(false ^ false); // output: False

            // logical OR
            Console.WriteLine(true | true); // output: True
            Console.WriteLine(true | false); // output: True
            Console.WriteLine(false | true); // output: True
            Console.WriteLine(false | false); // output: False

            // logical AND
            Console.WriteLine(true & true); // output: True
            Console.WriteLine(true & false); // output: False
            Console.WriteLine(false & true); // output: False
            Console.WriteLine(false & false); // output: False
        }

        public static void LogicalOperators2()
        {
            Console.WriteLine("& Versus &&:");

            // Logical AND: method SecondOperand is always called
            bool a = false & DataTypes.SecondOperand();
            Console.WriteLine($"{nameof(a)} is {a}");
            // Output:
            // Second operand is evaluated.
            // a is False

            bool b = true & DataTypes.SecondOperand();
            Console.WriteLine($"{nameof(b)} is {b}");
            // Output:
            // Second operand is evaluated.
            // b is True

            // Conditional Logical AND: if first operand is false,
            // method SecondOperand is not invoked
            // This is short—circuit evaluation
            bool c = false && SecondOperand();
            Console.WriteLine($"{nameof(c)} is {c}");
            // Output:
            // c is False

            bool d = true && SecondOperand();
            Console.WriteLine($"{nameof(d)} is {d} ");
            // Output:
            // Second operand is evaluated.
            // d is True
        }

        public static bool SecondOperand()
        {
            Console.WriteLine("Second operand is evaluated.");
            return true;
        }

        public static void LogicalOperators3()
        {
            Console.WriteLine("| Versus ||:");

            // Logical OR: method SecondOperand is always catted
            bool a = true | DataTypes.SecondOperand();
            Console.WriteLine($"{nameof(a)} is {a}");
            // Output:
            // Second operand is evaluated.
            // True

            bool b = false | DataTypes.SecondOperand();
            Console.WriteLine($"{nameof(b)} is {b}");
            // Output:
            // Second operand is evaluated.
            // True

            // Conditional Logical OR: if first operand is true,
            // Method SecondOperand is not invoked
            // This is short-circuit evaluation
            bool c = true || DataTypes.SecondOperand();
            Console.WriteLine($"{nameof(c)} is {c}");
            // Output:
            // True

            bool d = false || DataTypes.SecondOperand();
            Console.WriteLine($"{nameof(d)} is {d}");
            // Output:
            // Second operand is evaluated.
            // True
        }

        public static void BitwiseAndShiftOperators1()
        {
            Console.WriteLine("Bitwise and Shift Operators ~ << >>:");

            // bitwise complement
            uint a = 0b_000_1111_0000_1111_0000_1111_0000_1100;
            uint b = ~a;
            Console.WriteLine(Convert.ToString(b, toBase: 2));
            // Output:
            //11110000111100001111000011110011

            // left shift
            uint x = 0b_1100_1001_0000_0000_0000_0000_0001_0001;
            Console.WriteLine($"Before: {Convert.ToString(x, toBase: 2)}");
            uint y = x << 4; ;
            Console.WriteLine($"After:  {Convert.ToString(y, toBase: 2)}");
            // Output:
            // Before: 110010010000000000000000000010001
            // After:  100100000000000000000000100010000

            // right shift
            uint i = 0b_1001; ;
            Console.WriteLine($"Before: {Convert.ToString(i, toBase: 2),4}");
            uint j = i >> 2;
            Console.WriteLine($"Before: {Convert.ToString(j, toBase: 2),4}");
            // Output:
            // Before: 1001
            // After:    10
        }

        public static void BitwiseAndShiftOperators2()
        {
            Console.WriteLine("Bitwise and Shift Operators & ^ |:");
            // logical AND &
            uint d = 0b_1111_1000;
            uint e = 0b_1001_1101;
            uint f = d & e;
            Console.WriteLine(Convert.ToString(f, toBase: 2));
            // Output:
            // 10011000

            // logical Exclusive OR ^
            uint l = 0b_1111_1000;
            uint m = 0b_0001_1100;
            uint n = l ^ m;
            Console.WriteLine(Convert.ToString(n, toBase: 2));
            // Output:
            // 11100100

            // logical OR |
            uint o = 0b_1010_0000;
            uint p = 0b_1001_0001;
            uint q = o | p;
            Console.WriteLine(Convert.ToString(q, toBase: 2));
            // Output:
            // 10110001
        }

        public static void EqualityOperators1()
        {
            Console.WriteLine("Equality Operators ==");

            // value type equality
            int a = 1 + 2 + 3;
            int b = 6;
            Console.WriteLine(a == b); // output: True
            char c1 = 'a';
            char c2 = 'A';
            Console.WriteLine(c1 == c2); //output: False
            Console.WriteLine(c1 == char.ToLower(c2)); //output: True

            // reference type equality
            var car1 = new Car();
            var car2 = new Car();
            var car3 = car1;
            Console.WriteLine(car1 == car2); // output: False
            Console.WriteLine(car1 == car3); // output: True

            // string equality
            string s1 = "hello!";
            string s2 = "Hello!";
            Console.WriteLine(s1 == s2.ToLower()); // output: True
            string s3 = "Hello!";
            Console.WriteLine(s1 == s3); // output: False
        }

        public static void EqualityOperators2()
        {
            Console.WriteLine("Equality Operators !=");

            // value type inequality
            int c = 1 + 2 + 3 + 4;
            int d = 6;
            Console.WriteLine(c != d); // output: True

            // string inequality
            string s4 = "Hello";
            string s5 = "Hello";
            Console.WriteLine(s4 != s5); // output: False

            // reference type inequality
            object o1 = 1;
            object o2 = 1;
            Console.WriteLine(o1 != o2); // output: True
        }

        public static void Parsing()
        {
            Console.WriteLine("Parsing");

            try
            {
                int i = int.Parse("42");
                decimal dec = decimal.Parse("42.0");
                double dbl = double.Parse("123.45");
                Console.WriteLine("All parsing successfully completed");
            }
            catch (Exception exn)
            {
                Console.WriteLine("This text should NOT be printed");
            }
        }

        public static void IntegralConversions()
        {
            Console.WriteLine("Integral Conversions");

            int i = 4;
            long l = i; // implicit cast (widening)
            l += 3_000_000;            // 3 million
            // i = I; // implicit cast (narrowing so compile error)
            //l = long.MaxValue;
            i = (int)l; // explicit cast required to acknowledge potential data loss
            Console.WriteLine(i);
            // output: 3000004

            int j = 4;
            long k = j; // implicit cast (widening)
            k += 3_000_000_000; // int has a max value of 2_147_483_647
            // j  = k; // implicit cast (narrowing so compile error)
            j = (int)k; // explicit cast required to acknowledge potential data loss
            Console.WriteLine(j); // integer overflow results in an incorrect value
            // output: -1294967292
        }
    }
}
