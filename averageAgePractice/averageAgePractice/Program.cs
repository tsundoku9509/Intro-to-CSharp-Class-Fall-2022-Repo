/**********************
 * Name: averageAgePractice
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
 Input: User enters an age.
 *
 Output: String prints giving the average of all ages entered.
 * Academic Honesty: I attest that this is my original work. I have not used unauthorized source code, either modified or
 * unmodified. I have not given other fellow students access to my program.
**********************/

using System;

namespace AverageAge
{
    public class Program
    {
        public void averageAge()
        {
            int ages = 0;
            int age_01 = 0;
            int age_02 = 0;
            int age_03 = 0;
            int lifespan = 120;
            int limit = 500;
            int num_of_ages = 3;
        
            while (ages < limit)
            {
                if (age_01 < lifespan)
                {
                    Console.WriteLine("Enter an age: ");
                    age_01 = Convert.ToInt32(Console.ReadLine());
                }
                else if (age_01 > lifespan)
                {
                    Console.WriteLine("Error, no age over 120 accepted!");
                    age_01 = 0;
                }
                if (age_02 < lifespan)
                {
                    Console.WriteLine("Enter an age: ");
                    age_02  = Convert.ToInt32(Console.ReadLine());
                }
                else if (age_02 > lifespan)
                {
                    Console.WriteLine("Error, no age over 120 accepted!");
                    age_02 = 0;
                }
                if (age_03 < lifespan)
                {
                    Console.WriteLine("Enter an age: ");
                    age_03 = Convert.ToInt32(Console.ReadLine());
                }
                else if (age_03 > lifespan)
                {
                    Console.WriteLine("Error, no age over 120 accepted!");
                    age_03 = 0;
                }
                ages = age_01 + age_02 + age_03;
                double average = ages / num_of_ages;
                Console.WriteLine("The average is: " + average);
 
            }
   

        }
        public static void Main(String[] args)
        {
            Program p = new Program();
            p.averageAge();
            Console.ReadLine();

        }
    }
}

