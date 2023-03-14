using System;

/**********************
 *Name: MethodOverload
 * Author: Austin Mays
 * Created: 09/14/2022
 * Modified: 01/27/2023
 * Course: CIS 169 - C#
 * Version: 1.1
 * OS: macOS Ventura
 * IDE: Visual Studio 2022 Community
 * Copyright: This is my own original work based on specifications issued by our instructor.
 * Description: This program overall handles:
 *
 Input: None
 *
 Output: Type Decimal, Type Double, Type Decimal, and Type Int.
 * Academic Honesty: I attest that this is my original work. I have not used unauthorized source code, either modified or
 * unmodified. I have not given other fellow students access to my program.
**********************/


namespace MethodsOverload
{
    public class Program
    {
        private static decimal Average(float traffic, float accidents, float injury_index, decimal avg_ratio)
        {
            traffic = 1.44F;
            accidents = 5.25F;
            injury_index = 3.48F;
            avg_ratio = Convert.ToDecimal(traffic + accidents + injury_index / 3);
            Console.WriteLine("{0:N2}", avg_ratio);
            return avg_ratio;
        }
        private static double Average(decimal pay, decimal bonus, decimal yearly, double pay_ratio)
        {
            pay = 20.25M;
            bonus = 1.25M;
            yearly = 35000M;
            pay_ratio = Convert.ToDouble(pay + bonus + yearly / 3);
            Console.WriteLine("{0:N2}", pay_ratio);
            return pay_ratio;

        }
        private static decimal Average(int pizza_slices, int drinks, int chip_bags, decimal per_person)
        {
            pizza_slices = 8;
            drinks = 15;
            chip_bags = 20;
            per_person = Convert.ToDecimal(pizza_slices + drinks + chip_bags / 3);
            Console.WriteLine("{0:N2}", per_person);
            return per_person;

        }
        private static int Average(double calculation, double rotation, double counter_rotation, int num_computations)
        {
            calculation = 2.356;
            rotation = 3.9201;
            counter_rotation = 4.234;
            num_computations = Convert.ToInt32(calculation + rotation + counter_rotation / 3);
            Console.WriteLine("{0:N2}", num_computations);
            return num_computations;
        }
        public static void Main(string[] args)
        {
            float a, b, c;
            decimal d, e, f;
            int g, h, i;
            double j, k, l;
            a = 2.45F;
            b = 3.25F;
            c = 4.35F;
            decimal dec_avg = Convert.ToDecimal(a + b + c / 3);
            d = 30.25M;
            e = 20.34M;
            f = 3000.20M;
            double doub_age = Convert.ToDouble(d + e + f / 3);
            g = 10;
            h = 20;
            i = 30;
            decimal dec_avg_02 = Convert.ToDecimal(g + h + i / 3);
            j = 3.125;
            k = 2.456;
            l = 2.950;
            int int_avg = Convert.ToInt32(j + k + l / 3);
            decimal first;
            double second;
            decimal third;
            int fourth;

            first = Average(a, b, c, dec_avg);
            Console.WriteLine("Decimal Value: {0:N2}", first);
            second = Average(d, e, f, doub_age);
            Console.WriteLine("Double Value: {0:N2}", second);
            third = Average(g, h, i, dec_avg_02);
            Console.WriteLine("Decimal Value: {0:N2}", third);
            fourth = Average(j, k, l, int_avg);
            Console.WriteLine("Int 32bit Value: {0:N2}", fourth);
            Console.ReadLine();


        }
    }
}
