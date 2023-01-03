using System;



/**********************
 * Name: un-birthday_party
 * Author: Austin Mays
 * Created: 09/07/2022
 * Course: CIS 169 - C#
 * Version: 1.0
 * OS: macOS Big Sur
 * IDE: Visual Studio 2022 Community
 * Copyright: This is my own original work based on specifications issued by our instructor.
 * Description: This program overall handles:
 *              Input: The number of un-birthday guests, number of cupcakes, and how many each person should receive.
 *              Output: A message saying "My Un-Birthday Guests, Enjoy!" + "Number of Cupcakes Per Person" + cupcakePerPerson.
 * Academic Honesty: I attest thqat this is my original work. I have not used unauthorized source code, either modified or
 * unmodified. I have not given other fellow students access to my program.
**********************/



namespace un_birthday_party
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numberPeople = 0;
            int numberCupcakes = 0;
            double cupcakePerPerson;

            Console.WriteLine("Please enter the number of unbirthday people: ");
            try
            {
                numberPeople = Convert.ToInt32(Console.ReadLine());

            }
           catch (FormatException x)
            {
                Console.WriteLine("Error in output...");
                Console.WriteLine(x.Message);
            }
            Console.WriteLine("Please enter number of cupcakes: ");
            try
            {
                numberCupcakes = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException y)
            {
                Console.WriteLine("Error in output...");
                Console.WriteLine(y.Message);
            }
            cupcakePerPerson = numberPeople / numberCupcakes;
            Console.WriteLine("My Un-Birthday Guests, Enjoy!" + " Number of cupcakes per person: " + cupcakePerPerson);
            Console.ReadLine();

        }
    }
}

