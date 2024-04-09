using System;
using System.Diagnostics.Metrics;

namespace MethodFun
{
    internal class Program
    {//Return an int
        public static int AddTwoNumbers(int number1, int number2) // 2 Parameters
        {
            return number1 + number2;
        }

        public static void SquareANumber(int number)
        {
            number *= number;
            Console.WriteLine(number);
            return; //Execution stops here
            Console.WriteLine(number); // unreachable code
        }

        public static int AddTwoNumbersEB(int number1, int number2) =>  number1 + number2;

        public static void SquareANumberEB(int number) => Console.WriteLine(number *= number);


        static void SquareANumberByValue(int number)
        {
            Console.WriteLine(number *= number);
            return;
        }

        static void SquareANumberByRef(ref int number)
        {
            Console.WriteLine(number *= number);
            return;
        }

        static void OutExampleMethod(out int number, out string text, out string optionalString)
        {
            number = 42;
            text = "I'm output text";
            optionalString = null;
        }
        static (int number, string text, string? optionalString) TupleExampleMethod()
        {
            int number = 42;
            string text = "I'm output text";
            string? optionalString = null;
            return (number, text, optionalString);
        }
        static void SquareANumberUsingIn(in int number)
        {
            Console.WriteLine(number * number);
            //Console.WriteLine(number *= number); //Will error, cannot modify an "in" parameter
            return;
        }

        static void SwapStringsByValue(string s1, string s2)
        //String parameters are being passed by value
        //Any changes will NOT affect the original variables
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
            Console.WriteLine($"Inside the value swap method: {s1} {s2}");
        }

        static void SwapStringsByReference(ref string s1, ref string s2)
        //String parameters are being passed by reference
        //Any changes WILL affect the original variables
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
            Console.WriteLine($"Inside the ref swap method: {s1} {s2}");
        }

        static void ChangeModelByValue(Car car)
        //Any changes to actual car by pointing car 
        //at a new Car (or different car) will NOT affect the "caller" of method 
        //However, changes to its properties WILL be seen in 
        {
            car = new Car() { Make="AUDI", Model="TT"};
            //car.Model = "A6";
            Console.WriteLine($"Inside the value change method: {car.Make} {car.Model}");
        }

        static void ChangeModelByReference(ref Car car)
        //Any changes to actual car by pointing car variable
        //at a new Car WILL affect the original "caller" variable
        {
            car = new Car() { Make="AUDI", Model="TT"};
            //car.Model = "A6";
            Console.WriteLine($"Inside the value change method: {car.Make} {car.Model}");
        }


        static void Main(string[] args)
        {
            //Page 5: Named and Optional Parameters
            Car batMobile = new();
            batMobile.Register(name: "Bruce Wayne", postCode: "Unknown", address: "1007 Mountain Drive, Gotham", country: "USA");

            Car batBike = new();
            batBike.Register(name: "Bruce Wayne", postCode: "Unknown", address: "1007 Mountain Drive, Gotham");

            //Page 8: Method Return Values
            Console.WriteLine(AddTwoNumbers(4, 6));
            SquareANumber(10);

            //Page 10: Expression Bodied methods
            AddTwoNumbersEB(11, 12);
            SquareANumberEB(9);

            //Page 13: Passing Parameters ValueTypes by Value
            int x = 7;
            Console.WriteLine($"The value before calling the method: {x}");
            SquareANumberByValue(x); // Passing the variable by value.
            Console.WriteLine($"The value after calling the method: {x}");
            // The value before calling the method: 7
            // 49
            // The value after calling the method: 7

            //Page 14: Passing Parameters ValueTypes by Reference
            x = 7;
            Console.WriteLine($"The value before calling the method: {x}");
            SquareANumberByRef(ref x); // Passing the variable by reference.
            Console.WriteLine($"The value after calling the method: {x}");
            // The value before calling the method: 7
            // 49
            // The value after calling the method: 49


            //Page 15: Passing Parameters by "out"
            int argNumber;
            string argText, argOptionalString;
            OutExampleMethod(out argNumber, out argText, out argOptionalString);
            //Page 16: OR (From C# 7)
            //OutExampleMethod(out int argNumber, out string argText, out string argOptionalString);

            Console.WriteLine(argNumber);
            Console.WriteLine(argText);
            Console.WriteLine(argOptionalString == null);
            // Output
            // 42
            // I'm output text
            // True

            //Page 17: Returning Tuples
            var outputs = TupleExampleMethod();
            Console.WriteLine($"Outputs: number is {outputs.number}, text is {outputs.text}");
            Console.WriteLine($"Outputs: optional string is {outputs.optionalString ?? "NULL"}");

            //Page 18: Passing Parameters, Value types as "in" - this is the default method
            x = 7;
            Console.WriteLine($"The value before calling the method: {x}");
            SquareANumberUsingIn(x); // Passing the variable by value.
            Console.WriteLine($"The value after calling the method: {x}");
            // The value before calling the method: 7
            // 49
            // The value after calling the method: 7

            //Passing Reference Type Parameters
            //Pages 21 & 22: Note strings are a little unusual because,
            //although they are reference types, they are also 
            //immutable meaning they actually seem to behave as if they
            //were value types
            string str1 = "David";
            string str2 = "Attenborough";
            Console.WriteLine($"Before swapping by value: {str1} {str2}");
            SwapStringsByValue(str1, str2);
            Console.WriteLine($"After swapping by value: {str1} {str2}");
            // Before swapping by value: David Attenborough
            // Inside the value swap method: Attenborough David
            // After swapping by value: David Attenborough

            
            str1 = "David";
            str2 = "Attenborough";
            Console.WriteLine($"Before swapping by ref: {str1} {str2}");
            SwapStringsByReference(ref str1, ref str2);
            Console.WriteLine($"After swapping by ref: {str1} {str2}");
            // Before swapping by value: David Attenborough
            // Inside the value swap method: Attenborough David
            // After swapping by value: Attenborough David


            //Passing Reference Type Parameters OTHER THAN string - EXTRA
            //Pages 21 & 22: using a normal
            //Reference type
            Car carRef = new Car() { Make="Ford", Model="Fiesta" };
            Console.WriteLine($"Before calling ChangeModelByValue : {carRef.Make} {carRef.Model}");
            ChangeModelByValue(carRef);
            Console.WriteLine($"After calling ChangeModelByValue: {carRef.Make} {carRef.Model}");
            // Before calling ChangeModelByValue: Ford Fiesta
            // Inside the value swap method: Ford A6
            // After swapping by value: Ford A6


            carRef = new Car() { Make = "Ford", Model = "Fiesta" };
            Console.WriteLine($"Before calling ChangeModelByReference : {carRef.Make} {carRef.Model}");
            ChangeModelByReference(ref carRef);
            Console.WriteLine($"After calling ChangeModelByReference: {carRef.Make} {carRef.Model}");
            // Before calling ChangeModelByValue: Ford Fiesta
            // Inside the value swap method: Ford A6
            // After swapping by value: Ford A6

            //Page 25: Static
            x = 5;
            int y = 7;
            int lowest = Math.Min(x, y);
            int highest = Math.Max(x, y);
            Console.WriteLine($"The lowest value is { lowest }") ;
            Console.WriteLine($"The highest value is {highest}");
            /* Output:
            * The lowest value is 5
            * The highest value is 7
            */
            double price = 9.99;
            double priceFloor = Math.Floor(price);
            double priceRounded = Math.Round(price, 0);
            Console.WriteLine(priceFloor); // 9
            Console. WriteLine(priceRounded); // 10

            //Page 27: Instance Method Excample
            PassingParams pp = new PassingParams();
            x = 7;
            pp.SquareANumberInstanceMethod(7);

            PassingParams.SquareANumberStaticMethod(7);

            //Page 30: Extension Methods
            string s = "The Quick brown fox jumps over the lazy dog";
            int count = s.WordCount();
            Console.WriteLine($@"The string ""{s?.Trim():string.Empty}"" contains {count} word{((count != 1)?"s":string.Empty)}"); 
        }
    }
}