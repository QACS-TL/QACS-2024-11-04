namespace PropertiesFun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car { Colour = "Blue", Make = "Audi", WheelCount = 3 };
            Car car2 = new Car("Audi", "Quatro", 5) { Colour = "Red"};

            car.Colour = "XXXXXXX";
            Console.WriteLine(car.Colour);

            car.Make = "Audi";
            //car.Model = "A5"; //Model property is read only

            Console.WriteLine(car.Make);
            Console.WriteLine(car.Model);
            Console.WriteLine(car.Speed);
            Console.WriteLine(car.SpeedInKPH);



            Location home = new("Home");
            Location work = new("Work");
            Console.WriteLine(home.Name);
            Console.WriteLine(work.Name);
        }

    }
}
