using System;
using System.IO;
/**********************
 *Name: ReadWriteFile
 * Author: Austin Mays
 * Created: 10/12/2022
 * Course: CIS 169 - C#
 * Version: 1.0
 * OS: macOS Big Sur
 * IDE: Visual Studio 2022 Community
 * Copyright: This is my own original work based on specifications issued by our instructor.
 * Description: This program overall handles:
 *
 Input: None
 *
 Output: Program outputs the list from cities.txt with uppercase word beginnings. The program then stores the new list in a new file,
 citynames.txt, that is then appended with Des Moines as an addition.
 * Academic Honesty: I attest that this is my original work. I have not used unauthorized source code, either modified or
 * unmodified. I have not given other fellow students access to my program.
**********************/
namespace ReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string read = @"\ReadWriteFile\bin\Debug\net6.0\cities.txt";

            if (File.Exists(read))
            {
                string str = File.ReadAllText(read);
                Console.WriteLine(str);
                FormatName(read, str);
                File.WriteAllText(Path.Combine(read, "citynames.txt"), str);
                Console.ReadLine();

                if (File.Exists(read))
                {
                    string[] writing = { "Des", "Moines" };
                    File.AppendAllLines(Path.Combine(read, "citynames.txt"), writing);
                }
            }
        }
        static void FormatName(string file, string uppercase)
        {
            Console.WriteLine("");
            file = Console.ReadLine();
            uppercase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(file.ToLower());
            Console.WriteLine(uppercase);
            Console.ReadKey();
        }
    }
}
