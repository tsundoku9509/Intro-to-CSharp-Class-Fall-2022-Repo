using System;

/**********************
 *Name: jaggedArrays
 * Author: Austin Mays
 * Created: 10/05/2022
 * Modified: 01/26/2023
 * Course: CIS 169 - C#
 * Version: 1.1
 * OS: macOS Ventura
 * IDE: Visual Studio 2022 Community
 * Copyright: This is my own original work based on specifications issued by our instructor.
 * Description: This program overall handles:
 *
 Input: Takes a set of rows within a table and calls methods to main to find the closest and furthest
city pitstop.
 *
 Output: Outputs the closet and furthest as a string.
 * Academic Honesty: I attest that this is my original work. I have not used unauthorized source code, either modified or
 * unmodified. I have not given other fellow students access to my program.
**********************/

namespace JaggedArrays
{
    class Program
    {
        public static void Min(int[] mileageTable)
        {
            int pitstop_total = 9;
            int[][] pitstop_min = new int[pitstop_total][];
            for (int i = 0; i < pitstop_min.Length; i++)
            {
                pitstop_min[i] = new int[1];
                Console.WriteLine("#{0}:\t", i + 1);
            }
        }
        public static void Max(int[] mileageTable)
        {
            int pitstop_total = 9;
            int[][] travel_max = new int[pitstop_total][];
            for (int i = 9; i == travel_max.Length;)
            {
                travel_max[i] = new int[9];

            }
        }
        public static void Main(String[] args)
        {
            string[] cityList = {"Edinburgh", "Burmingham", "Cardiff",
            "Dover", "Leeds", "Liverpool", "London", "Manchester", "NewCastle", "York"};
            const int mileage = 9;
            int[][] mileageTable = new int[mileage][];
            mileageTable[0] = new int[9] { 290, 373, 496, 193, 214, 412, 222, 112, 186 };
            mileageTable[1] = new int[8] { 102, 185, 110, 90, 118, 86, 207, 129 };
            mileageTable[2] = new int[7] { 228, 208, 165, 150, 173, 301, 231 };
            mileageTable[3] = new int[6] { 257, 270, 81, 285, 360, 264 };
            mileageTable[4] = new int[5] { 73, 191, 41, 94, 25 };
            mileageTable[5] = new int[4] { 198, 34, 155, 97 };
            mileageTable[6] = new int[3] { 201, 288, 194 };
            mileageTable[7] = new int[2] { 141, 66 };
            mileageTable[8] = new int[1] { 82 };
            for (int i = 0; i < mileage; i++)
            {
                Console.WriteLine("#{0}:\t", i + 1);
                for (int j = 0; j < mileageTable[i].Length; j++)
                {
                    Console.Write(mileageTable[i][j] + "\t");
                    if (i == 9)
                    {
                        Min(mileageTable[6]);
                        Console.ReadKey();
                        Max(mileageTable[6]);
                        Console.ReadKey();
                        Console.ReadLine();
                    }
                }
                Console.WriteLine();
                Console.ReadLine();
            }
 
        }
    }
}