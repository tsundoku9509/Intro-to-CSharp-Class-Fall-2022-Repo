using System;

/**********************
 * Name: daysOfTheWeekMays
 * Author: Austin Mays
 * Created: 09/21/2022
 * Course: CIS 169 - C#
 * Version: 1.0
 * OS: macOS Big Sur
 * IDE: Visual Studio 2022 Community
 * Copyright: This is my own original work based on specifications issued by our instructor.
 * Description: This program overall handles:
 *
 Input: Int 32 number of day of the week, 1-7.
 *
 Output: The Day of the Week Based on Number Input.
 * Academic Honesty: I attest that this is my original work. I have not used unauthorized source code, either modified or
 * unmodified. I have not given other fellow students access to my program.
**********************/

namespace DateTime
{
    public class StringSwitch
    {
        static public void Main()
        {
            Console.WriteLine("What Number of Day of the Week is Today?");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday"); break;
                case 2:
                    Console.WriteLine("Monday"); break;
                case 3:
                    Console.WriteLine("Tuesday"); break;
                case 4:
                    Console.WriteLine("Wednesday"); break;
                case 5:
                    Console.WriteLine("Thursday"); break;
                case 6:
                    Console.WriteLine("Friday"); break;
                case 7:
                    Console.WriteLine("Saturday"); break;
                default:
                    day = -1; break;

            }
            if (day <= 0)
            {
                Console.WriteLine("Invalid Date!");
            }
            else if (day <= 7)
            {
                Console.WriteLine("Today is day " + day + " of the week!");
            }
            Console.ReadLine();
        }
    }
}