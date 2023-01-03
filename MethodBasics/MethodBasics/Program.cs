using System;
using System.Data;

namespace Methods
{
    class Program
    {
        private static decimal NewPrice()
        {
            decimal price = 25.99M;
            Console.WriteLine("Price: $" + price);
            decimal discount = price * 0.20M;
            Console.WriteLine("Discount: $" + discount);
            try
            {
                discount = Convert.ToDecimal(string.Format("{0:0.00}", Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("Error occurred in numeric values.");
            }
            decimal final = discount + price;
            Console.WriteLine("Final Price After Discount: $" + final);
            try
            {
                final = Convert.ToDecimal(string.Format("{0:0.00}", Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("Error occurred in numeric values.");
            }
            Console.ReadLine();
            return final;

        }
        private static int DisplayNumericData()
        {
            int number = 35;
            Console.WriteLine(number);
            try
            {
                number = (int)Convert.ToDecimal(string.Format("{0.00}", Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("Error occurred in numeric values.");
            }
            Console.ReadLine();
            return number;
        }
        public static void Main(string[] args)
        {
            decimal price;
            decimal discount;
            decimal final;
            price = NewPrice();
            discount = NewPrice();
            final = NewPrice();
            int number;
            number = DisplayNumericData();
            Console.WriteLine("I chose decimal for money, and int to change into a decimal");
            Console.ReadLine();
        }
    }
}


