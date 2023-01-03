using System;

namespace AverageAge
{
    public class Program
    {
        public void averageAge()
        {
            int ages = 0;
            int num_of_ages = 3;
        
            while (ages < 120)
            {
                Console.WriteLine("Enter an age: ");
                int age_01 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter an age: ");
                int age_02 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter an age: ");
                int age_03 = Convert.ToInt32(Console.ReadLine());
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

