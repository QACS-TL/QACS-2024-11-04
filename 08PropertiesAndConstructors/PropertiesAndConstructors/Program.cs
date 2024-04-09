namespace PropertiesAndConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03 Fields
            // fields do not provide validation beyond the datatype
            Car c1 = new();
            Car c2 = new();
            c1.make = "Ford";
            c2.make = "Ferrari";
            c1.model = "Fiesta";
            c2.model = "Flying Submarine"; //not realistic
            c1.speed = 9999; //not realistic

            //06 and 07 Properties with Backing Fields
            PropertiesAndConstructors2.Car c3 = new PropertiesAndConstructors2.Car();
            c3.Speed = 30;
            Console.WriteLine(c3.Speed);

            c3.EngineSize = 1200;
            Console.WriteLine(c3.EngineSize);

            //08 Auto-Implemented Properties
            c3.Make = "Audi";
            Console.WriteLine(c3.Make);
            Console.WriteLine(c3.NumberOfDoors);

            //09 Calculated Property Example
            Temperature temperature =new Temperature();
            temperature.TempInDegreesCelcius = 100;
            Console.WriteLine($"temp in celcius: {temperature.TempInDegreesCelcius}");
            Console.WriteLine($"temp in farenheit: {temperature.TempInDegreesFarenheit}");
            Console.WriteLine($"alternative expression bodied temp in farenheit: {temperature.TempInDegreesFarenheitAlt}");


            // 10 Accessing Properties
            // instantiate a Car object Instance
            PropertiesAndConstructors2.Car c4 = new();
            // set a property value
            c4.Model = "Xr2i";
            // get property values
            Console.WriteLine(c4.Model);
            Console.WriteLine(c4.Make) ;
            Console.WriteLine(c4.Speed);

            //13 & 14 Constructor Example: Employee With Read - only Fields

            Employee unknown = new(); //parameter-less constructor
            Employee spiderman = new Employee("Peter", "Parker", 1); // 3 arg constructor
            Console.WriteLine($"Hi, I'm {spiderman.firstName} {spiderman.lastName} and my employee id is {spiderman.employeeID}");

            //15 Constructor Example: Employee With Auto-implemented properties
            PropertiesAndConstructors2.Employee catwoman = new ("Selina", "Kyle", 2);
            Console.WriteLine($"Hi, I'm {catwoman.FirstName} {catwoman.LastName} and my employee id is {catwoman.EmployeeID}");


            //16 Constructor Example: Employee With full properties
            PropertiesAndConstructors2.Employee batgirl = new("Barbara", "Gordon", 3);
            Console.WriteLine($"Hi, I'm {batgirl.FirstName} {batgirl.LastName} and my employee id is {batgirl.EmployeeID}");

            //17 Expression Bodied Constructors
            Location home = new("Home");
            Location work = new("Work");
            Console.WriteLine(home.Name);
            Console.WriteLine(work.Name);

            //18 Contructor Overloading
            PropertiesAndConstructors3.Car car5 = new();
            PropertiesAndConstructors3.Car car6 = new("Audi");
            PropertiesAndConstructors3.Car car7 = new("Audi", "TT");

            Console.WriteLine($"Car 5 is a {car5.Make} {car5.Model}");
            Console.WriteLine($"Car 6 is a {car6.Make} {car6.Model}");
            Console.WriteLine($"Car 7 is a {car7.Make} {car7.Model}");

            //19 Contructor Chaining
            PropertiesAndConstructors4.Car car8 = new();
            PropertiesAndConstructors4.Car car9 = new("Audi");
            PropertiesAndConstructors4.Car car10 = new("BMW", "X5");

            //PropertiesAndConstructors4.Car carx = PropertiesAndConstructors4.Car.CreateCar("Ford", "Mondeo");

            Console.WriteLine($"Car {nameof(car8)} is make: {car8.Make} and model: {car8.Model}");
            Console.WriteLine($"Car {nameof(car9)} is make: {car9.Make} and model: {car9.Model}");
            Console.WriteLine($"Car {nameof(car10)} is make: {car10.Make} and model: {car10.Model}");
            // Output:
            // Car cl is make: Unknown and model: Unknown model
            // Car c2 is make: Audi and model: Unknown model
            // Car c3 is make: BMW and model: X5

            //20 Object Initialisers
            // parameter—less constructor is used implicitly with an object initializer
            PropertiesAndConstructors4.Car car11 =
                new PropertiesAndConstructors4.Car { Make = "Audi", Model = "TT", Speed = 70 };

            Console.WriteLine($"Car {nameof(car11)} is make: {car11.Make} and model: {car11.Model} and Speed: {car11.Speed}");
            // an explicit constructor can be used with an object initializer
            PropertiesAndConstructors4.Car car12 =
                new PropertiesAndConstructors4.Car("Audi", "TT") { Speed = 70 };
            Console.WriteLine($"Car {nameof(car12)} is make: {car12.Make} and model: {car12.Model} and Speed: {car12.Speed}");

            //22 Static Constructors
            PropertiesAndConstructors4.Employee emp4 = new();
            //Can't refer to static fields (or methods) from within an instance
            //Console.WriteLine($"Employee {nameof(emp4)} works for {emp4.companyName}"); 
            Console.WriteLine($"All employees work for {PropertiesAndConstructors4.Employee.companyName}");

            //23 The "This" Keyword
            PropertiesAndConstructors4.Employee emp5 = new("Janet", "Van Dyne", 4);
            Console.WriteLine( $"Seat number {emp5.OfficeSeatNumber} booked for {emp5.FirstName} {emp5.LastName} (emp id {emp5.EmployeeID})");
        }
    }
}