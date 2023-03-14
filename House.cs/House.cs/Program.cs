using System;
using Module9;
/**********************
* Name: House.CS
* Author: Austin Mays
* Created: 10/19/2022
* Modified: 02/08/2023
* Course: CIS 169 - C#
* Version: 1.1
* OS: macOS Ventura
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
        Address add_01 = new Address(1521, "Valiant St", "Mason", "VA", 10123);
        House houseOne = new House(add_01, 2, 3);

        Address add_02 = new Address(1330, "KIOA DR", "West Watertown", "CA", 30040);
        House houseTwo = new House(add_02, 5, 3);

        Address add_03 = new Address(1776, "Independence Ave", "Nesting", "LA", 40321);
        House houseThree = new House(add_03, 10, 5);

        Address add_04 = new Address(2349, "Saint Rd", "Wesley", "MN", 50320);
        House houseFour = new House(add_04, 4, 3);

        Address add_05 = new Address(1200, "Tree Ct", "Roundabout", "CO", 30220);
        House houseFive = new House(add_05, 4, 2);
        
        List<House> myHouse = new List<House>(5);
        myHouse.Add(houseOne);
        myHouse.Add(houseTwo);
        myHouse.Add(houseThree);
        myHouse.Add(houseFour);
        myHouse.Add(houseFive);

        foreach(House h in myHouse)
        {
            Console.WriteLine("Address = {0} | NumberBedrooms = {1} | NumberBathrooms = {2}", h.Address, h.NumberBedrooms, h.NumberBathrooms);
        }
        Console.ReadLine();
	}
}


