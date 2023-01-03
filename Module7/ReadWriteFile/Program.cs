using System;
using System.IO;

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
