using System;
/**********************
 *Name: decideMeal
 * Author: Austin Mays
 * Created: 09/21/2022
 * Course: CIS 169 - C#
 * Version: 1.0
 * OS: macOS Big Sur
 * IDE: Visual Studio 2022 Community
 * Copyright: This is my own original work based on specifications issued by our instructor.
 * Description: This program overall handles:
 *
 Input: Day of the Week and Meal Time.
 *
 Output: Day and the Meal available during that alloted time (lunch or dinner).
 * Academic Honesty: I attest that this is my original work. I have not used unauthorized source code, either modified or
 * unmodified. I have not given other fellow students access to my program.
**********************/
namespace Meal
{
    public class Program
    {
        public static void decideMeal() 
        {
            bool mon = true;
            bool tue = true;
            bool wed = true;
            bool thurs = true;
            bool lunch = true;
            bool dinner = true;
            string m = "Monday";
            string t = "Tuesday";
            string w = "Wednesday";
            string th = "Thursday";
            string lun = "Lunch";
            string din = "Dinner";
            bool.TryParse(m, out mon);
            bool.TryParse(t, out tue);
            bool.TryParse(w, out wed);
            bool.TryParse(th, out thurs);
            bool.TryParse(lun, out lunch);
            bool.TryParse(din, out dinner);
            string mealString;
            Console.WriteLine("Enter the day for meals info: ");
            try
            {
                mealString = Convert.ToString(Console.ReadLine());
            }
            catch (FormatException y)
            {
                Console.WriteLine("Error Occurred!");
                Console.WriteLine(y.Message);
            }
            Console.ReadLine();

            if (mon)
            {
                Console.WriteLine("Monday: ");
                if (lunch)
                {
                    Console.WriteLine("Today for lunch we have pizza and garlic dipping sticks.");
                    if (dinner)
                    {
                        Console.WriteLine("Tonight for dinner is a plate of stake and mashed potatoes");
                    }
                }

                else
                {
                    Console.WriteLine("See you tomorrow!");
                }
            }

            if (tue)
            {
                Console.WriteLine("Tuesday: ");
                if (lunch)
                {
                    Console.WriteLine("Today brings with it a nice bowl of soup and crackers!");
                    if (dinner)
                    {
                        Console.WriteLine("Tonight is wings and salad!");
                    }
                }
                else
                {
                    Console.WriteLine("See you on hump day!");
                }
            }

            if (wed)
            {
                Console.WriteLine("Wednesday: ");
                if (lunch)
                {
                    Console.WriteLine("Today is all about health, granola bars and yogurt. :) ");
                    if (dinner)
                    {
                        Console.WriteLine("Tonight is lasagna and garlic bread!");
                    }
                }
                else
                {
                    Console.WriteLine("See you tomorrow!");
                }
            }

            if (thurs)
            {
                Console.WriteLine("Thursday: ");
                if (lunch)
                {
                    Console.WriteLine("Lunch for today consists of turkey and beans.");
                    if (dinner)
                    {
                        Console.WriteLine("Dinner is a nice wine and spaghetti!");
                    }
                }
                else
                {
                    Console.WriteLine("Have an amazing weekend!");
                }
            }
        }
                        

                    
                
            
        


        public static void Main(String[] args)
        {
            decideMeal();
            
            Console.ReadLine();
        }
    }
}

