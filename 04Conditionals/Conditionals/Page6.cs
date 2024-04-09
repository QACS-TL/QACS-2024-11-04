namespace Conditionals
{

    public enum Country
    {
        England,
        NorthernIreland,
        Scotland,
        Wales
    }

    public class VotingFun
    {

        public static void CanIVote(int age)
        {

            int votingAge = 18;
            {
                if (age >= votingAge)
                    Console.WriteLine("You are eligible to vote in the election");
            }


            if (age >= votingAge)
            {
                Console.WriteLine("You are eligible to vote in the election");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote in the election");
            }
        }


        public static void CanIVote(int age, Country country)
        {
            if ((country == Country.Wales || country == Country.Scotland) && age >= 16)
            {
                Console.WriteLine("You are eligible to vote in the Welsh / Scottish election");
            }
            else if ((country == Country.England || country == Country.NorthernIreland) && age >= 18)
            {
                Console.WriteLine("You are eligible to vote in the English / Northern Irish election");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote in the election");
            }
        }
    }
}