using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class TernaryOperator
    {
        enum Coin
        {
            Heads,
            Tails
        }
        public static void CoinToss()
        {
            var coin = Coin.Tails;
            // IF statement syntax
            string status;
            if (coin == Coin.Heads)
            {
                status = "won";
            }
            else
            {
                status = "lost";
            }
            Console.WriteLine($"You {status} the toss");
            // Ternary operator ? :
            string status2 = (coin == Coin.Heads) ? "won" : "lost";
            Console.WriteLine($"You {status2} the toss");
        }
    }
}
