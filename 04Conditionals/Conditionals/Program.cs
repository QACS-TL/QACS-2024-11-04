

using Conditional;
using System.Dynamic;

namespace Conditionals
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Page 6
            VotingFun.CanIVote(15); //No
            VotingFun.CanIVote(16); //No
            VotingFun.CanIVote(17); //No
            VotingFun.CanIVote(18); //Yes

            VotingFun.CanIVote(15, Country.Wales); //No
            VotingFun.CanIVote(15, Country.Scotland); //No
            VotingFun.CanIVote(15, Country.England); //No
            VotingFun.CanIVote(15, Country.NorthernIreland); //No
            VotingFun.CanIVote(16, Country.Wales); //Yes
            VotingFun.CanIVote(16, Country.Scotland); //Yes
            VotingFun.CanIVote(16, Country.England); //No
            VotingFun.CanIVote(16, Country.NorthernIreland); //No

            VotingFun.CanIVote(18, Country.Wales); //Yes
            VotingFun.CanIVote(18, Country.Scotland); //Yes
            VotingFun.CanIVote(18, Country.England); //Yes
            VotingFun.CanIVote(18, Country.NorthernIreland); //Yes

            //Page 7
            Console.WriteLine($"There are {CalendarFun.GetDaysInMonth(1)} days in month number {"February"}");
            Console.WriteLine($"There are {CalendarFun.GetDaysInMonth(3)} days in month number {"April"}");
            Console.WriteLine($"There are {CalendarFun.GetDaysInMonth(4)} days in month number {"May"}");
            Console.WriteLine($"There are {CalendarFun.GetDaysInMonth(5)} days in month number {"June"}");

            Console.WriteLine($"There are {CalendarFun.GetDaysInMonth("February")} days in month number {"February"}");
            Console.WriteLine($"There are {CalendarFun.GetDaysInMonth("March")} days in month number {"March"}");
            Console.WriteLine($"There are {CalendarFun.GetDaysInMonth("April")} days in month number {"April"}");

            //Page 8
            ParliamentsFun.GetParliament(Country.Wales);
            ParliamentsFun.GetParliament(Country.Scotland);
            ParliamentsFun.GetParliament(Country.NorthernIreland);
            ParliamentsFun.GetParliament(Country.England);
            ParliamentsFun.GetParliament((Country)6);

            //Page 9
            // Output: Measured value is —4; too tow.
            MeasuringFun.DisplayMeasurement(-4);
            MeasuringFun.DisplayMeasurement(5);
            // Output: Measured value is 5.
            MeasuringFun.DisplayMeasurement(30); // Output: measured value is 30; too high.
            MeasuringFun.DisplayMeasurement(double.NaN); // Output: Failed measurement.

            //Page 10
            var country = Country.England;
            Console.WriteLine($"Country name is { country }" ) ;
            Console.WriteLine($"parliament name is {SwitchExpressionParliamentFun.GetParliament(country)}");

            //Page 14
            SwitchGuardMeasuringFun.DisplayMeasurements(7, 6);
            SwitchGuardMeasuringFun.DisplayMeasurements(8, 8);
            SwitchGuardMeasuringFun.DisplayMeasurements(5, -3);

            //Page 15
            SwitchExpressionCaseGuard.DoTransforms();

            //Page 16
            TernaryOperator.CoinToss();

            //Page20
            NullOperators.Addressing();





    //Dog dog = null;

    //Console.WriteLine($"Will my dog bark? {dog?.Bark()}");

    //Mammal m = new Mammal();
    //Dog d = (Dog)m.GetMammal(Animal.Dog);
    //Console.WriteLine(d.Bark());

    //Cat c = (Cat)m.GetMammal(Animal.Cat);
    //Console.WriteLine(c.Meow());
    //Console.WriteLine(m.Move());

    //Mammal nm = m.GetMammal(Animal.Elephant);
    //Console.WriteLine($"{(nm == null ? "Squeak" : nm.Move())}");

}

   }

    public class Dog : Mammal
    {
        public string Bark()
        {
            return "Woof";
        }
    }

    public class Cat : Mammal
    {
        public string Meow()
        {
            return "Meow";
        }
    }

    public class Mammal
    {
        public Mammal GetMammal(Animal mammalNumber)
        {
            //switch (mammalNumber)
            //{
            //    case Animal.Dog:

            //        return new Dog();
            //    case Animal.Cat:
            //        return new Cat();
            //}
            //return null;

            Mammal mammal = mammalNumber switch
            {
                Animal.Dog => new Dog(),
                Animal.Cat => new Cat(),
                _ => null
            };
            return mammal;


        }

        public string Move()
        {
            return "Plod plod";
        }
    }

    public enum Animal
    {
        Dog,
        Cat,
        Mouse,
        Elephant
    }
}
