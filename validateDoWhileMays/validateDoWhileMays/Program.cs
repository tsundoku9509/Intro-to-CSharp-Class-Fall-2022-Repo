using System;

/**********************
 *Name: validateDoWhileMays
 * Author: Austin Mays
 * Created: 09/28/2022
 * Course: CIS 169 - C#
 * Version: 1.0
 * OS: macOS Big Sur
 * IDE: Visual Studio 2022 Community
 * Copyright: This is my own original work based on specifications issued by our instructor.
 * Description: This program overall handles:
 *
 Input: An integer from 0 to 50, asking for increments of ten each time with a do while loop.
 *
 Output: Outputs a message to the console once all five increments have been entered with the average of the five entries. Also writes to console the five numeric entries and a message to follow prior to final message.
 * Academic Honesty: I attest that this is my original work. I have not used unauthorized source code, either modified or
 * unmodified. I have not given other fellow students access to my program.
**********************/

namespace Validate
{
    class Program
    {
        public static void Main(String[] args)
        {
            int num;
            int num_div = 5;
            int num_final;



            do
            {
                Console.WriteLine("Enter a number incremeant of 10 from 0 to 50! ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Great Job!");
            } while (num < 50);

            num_final = num / num_div;
            Console.WriteLine("The average between all five is: " + num_final);
            Console.ReadLine();

        }

    }
}