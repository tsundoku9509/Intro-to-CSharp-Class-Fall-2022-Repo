using System;
/**********************
 *Name: Program.CS
 * Author: Austin Mays
 * Created: 10/19/2022
 * Course: CIS 169 - C#
 * Version: 1.0
 * OS: macOS Big Sur
 * IDE: Visual Studio 2022 Community
 * Copyright: This is my own original work based on specifications issued by our instructor.
 * Description: This program overall handles:
 *
 Input: None
 *
 Output: Program outputs the string based on the parameters from the public class House fed through the preset variables in the list within the Main Method.
 * Academic Honesty: I attest that this is my original work. I have not used unauthorized source code, either modified or
 * unmodified. I have not given other fellow students access to my program.
**********************/
public class Program
{
	public static void Main(string[] args)
	{
        House houseOne = new House()
        {
            Address = "1521 Valiant St, Mason, VA",
            NumberBedrooms = 2,
            NumberBathrooms = 3
        };
        House houseTwo = new House()
        {
            Address = "1330 KIOA DR, West Watertown, CA",
            NumberBedrooms = 5,
            NumberBathrooms = 3
        };
        House houseThree = new House()
        {
            Address = "1776 Independence Ave, Nesting, LA",
            NumberBedrooms = 10,
            NumberBathrooms = 5
        };
        House houseFour = new House()
        {
            Address = "2349 Saint Rd, Wesley, MN",
            NumberBedrooms = 4,
            NumberBathrooms = 3
        };
        House houseFive = new House()
        {
            Address = "1200 Tree Ct, Roundabout, CO",
            NumberBedrooms = 4,
            NumberBathrooms = 2
        };
        List<House> myHouse = new List<House>(5);
        myHouse.Add(houseOne);
        myHouse.Add(houseTwo);
        myHouse.Add(houseThree);
        myHouse.Add(houseFour);
        myHouse.Add(houseFive);

        foreach(House h in myHouse)
        {
            Console.WriteLine("Address={0}, NumberBedrooms={1}, NumberBathrooms={2}", h.Address, h.NumberBedrooms, h.NumberBathrooms);
        }
        Console.ReadLine();
	}
}


