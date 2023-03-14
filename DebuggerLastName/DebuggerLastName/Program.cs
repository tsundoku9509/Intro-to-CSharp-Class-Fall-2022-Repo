/**********************
 * Name: DebuggerLastName
 * Author: Austin Mays
 * Created: 2022
 * Modified 01/26/2023
 * Course: CIS 169 - C#
 * Version: 1.1
 * OS: macOS Ventura
 * IDE: Visual Studio 2022 Community
 * Copyright: This is my own original work based on specifications issued by our instructor.
 * Description: This program overall handles:
 *
 Input: None.
 *
 Output: String declaring the winner of the medal.
 * Academic Honesty: I attest that this is my original work. I have not used unauthorized source code, either modified or
 * unmodified. I have not given other fellow students access to my program.
**********************/


using System;


namespace DebuggerLastName
{
    class Program
    {
        public static string MedalWinner(string fName, string lName, string rank)
        {
            string result;
            result = fName + " " + lName + " Rank: " + rank;
            return result;

        }

        public static void Main(string[] args)
        {
            // Call a method that returns the user's first name
            // first letter capitalized only
            // and the last name all capitalized followed by rank // Austin Mays
            string winner1 = MedalWinner("Austin", "Mays", "1");
            string winner2 = MedalWinner("USA", "Women's Soccer", "1");
            string winner3 = MedalWinner("USA", "Women's Soccer", "1.5");
            string winner4 = MedalWinner("USA", "Men's Soccer", "1");
            Console.WriteLine("And the winner is ... {0:G}", winner1);
            Console.WriteLine("Expected: Austin MAYS Rank: 1");
            Console.WriteLine("Press Enter for Next Winner!");
            Console.ReadLine();
            Console.WriteLine("And the winner is ... {0:G}", winner2);
            Console.WriteLine("Expected: Usa WOMEN'S SOCCER Rank: 1");
            Console.WriteLine("Press Enter for Next Winner!");
            Console.ReadLine();
            Console.WriteLine("And the winner is ... {0:G}", winner3);
            Console.WriteLine("Expected: Usa WOMEN'S SOCCER Rank: 1.5");
            Console.WriteLine("Press Enter for Next Winner!");
            Console.ReadLine();
            Console.WriteLine("And the winner is ... {0:G}", winner4);
            Console.WriteLine("Expected: Usa MEN'S SOCCER Rank: undetermined");
            Console.WriteLine();
        }
    }
}