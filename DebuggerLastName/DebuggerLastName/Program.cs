using System;


namespace DebuggerLastName
{
    class Program
    {
        private static string MedalWinner(string fName, string lName, string rank)
        {
            string result; result = fName + " " + lName; result = result + " Rank: " + Convert.ToInt32(rank).ToString(); return result;

            try
            {
                result = result + Convert.ToInt32(rank).ToString();

            }
            catch (FormatException e)
            {
                result = result + " Rank: undetermined";

            }

            try { result = result + Convert.ToInt32(rank).ToString(); }
            catch (FormatException e)
            {
                result = result + Convert.ToDecimal(rank).ToString();

            }
        }

        static void Main(string[] args)
        {
            // Call a method that returns the user's first name
            // first letter capitalized only
            // and the last name all capitalized followed by rank // Austin Mays
            string winner1 = MedalWinner("Austin", "Mays", "1");
            string winner2 = MedalWinner("USA", "Women's Soccer", "1");
            string winner3 = MedalWinner("USA", "Women's Soccer", "1.5");
            string winner4 = MedalWinner("USA", "Men's Soccer", "GOLD");
            Console.WriteLine("And the winner is ... {0:G}", winner1);
            Console.WriteLine("Expected: Austin MAYS Rank: 1");
            Console.WriteLine("And the winner is ... {0:G}", winner2);
            Console.WriteLine("Expected: Usa WOMEN'S SOCCER Rank: 1");
            Console.WriteLine("And the winner is ... {0:G}", winner3);
            Console.WriteLine("Expected: Usa WOMEN'S SOCCER Rank: 1.5");
            Console.WriteLine("And the winner is ... {0:G}", winner4);
            Console.WriteLine("Expected: Usa MEN'S SOCCER Rank: undetermined");
        }
    }
}