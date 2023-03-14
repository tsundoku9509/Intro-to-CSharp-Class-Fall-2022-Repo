/**********************
 * Name: MethodBasics
 * Author: Austin Mays
 * Created: 2022
 * Modified: 01 / 27 / 2023
 * Course: CIS 169 - C#
 * Version: 1.1
 * OS: macOS Ventura
 * IDE: Visual Studio 2022 Community
 * Copyright: This is my own original work based on specifications issued by our instructor.
 * Description: This program overall handles:
 * Input: A whole/decimal numerical value representing a price and a second entry representing a whole number.
 * Output: Program outputs the first as a price after the discount is added, while the second outputs the whole number as a decimal value.
 * Academic Honesty: I attest thqat this is my original work. I have not used unauthorized source code, either modified or
 * unmodified. I have not given other fellow students access to my program.
**********************/

using System;
using System.Data;
using System.Diagnostics;

namespace Methods
{
    class Program
    {
        public decimal NewPrice(decimal price)
        {
            Console.WriteLine("Price: $" + price);

            decimal discount = price * 0.20M;
            Console.WriteLine("Discount: ${0:N2}", discount);
   
            decimal final = price - discount;
            Console.WriteLine("Final Price After Discount: ${0:N2}", final);
            Console.ReadLine();
            return final;

        }
        public int DisplayNumericData(int number)
        {
            Console.WriteLine(number);
            decimal numDec = Convert.ToDecimal(number);
            Console.WriteLine("The whole number changed to decimal: {0:n2}", numDec);
            
            Console.ReadLine();
            return number;
        }
        public static void Main(string[] args)
        {
            decimal newNull = 0.00M;
            decimal newPrice = newNull;
            while (newPrice == newNull)
            {

                try
                {

                    Console.WriteLine("Enter your new price: ");
                    newPrice = Convert.ToDecimal(Console.ReadLine());
                    Program p = new Program();
                    newPrice = p.NewPrice(newPrice);
                    Console.WriteLine("Press enter for next prompt: ");
                    Console.ReadLine();
                    Console.WriteLine("Enter a new whole number: ");
                    int newNumber = Convert.ToInt32(Console.ReadLine());
                    newNumber = p.DisplayNumericData(newNumber);

                    //I chose a decimal for money, and an int to change into a decimal.

                    Console.ReadLine();
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
         
        }
    }
}


