/**********************
 * Name: BillTipTaxMays
 * Author: Austin Mays
 * Created: 2022
 * Modified 01/26/2023
 * Course: CIS 169 - C#
 * Version: 1.1
 * OS: macOS Ventura
 * IDE: Visual Studio 2022 Community
 * Copyright: This is my own original work based on specifications issued by our instructor.
 * Description: This program overall handles:
 *
 Input: None.
 *
 Output: String telling each customer what amount is due based on the split bill and tax.
 * Academic Honesty: I attest that this is my original work. I have not used unauthorized source code, either modified or
 * unmodified. I have not given other fellow students access to my program.
**********************/

using System;

namespace BillTipTax
{
    class Program
    {
        static void Main(string[] args)
        {
            double TAXRATE = 0.07;
            double TIP_PERCENT = 0.20;
            double MEAL_ONE = 25.50;
            double MEAL_TWO = 23.45;
            double DESSERT_ONE = 4.50;
            double DESSERT_TWO = 3.75;
            double SUBTOTAL_ONE = MEAL_ONE + DESSERT_ONE;
            double SUBTOTAL_TWO = MEAL_TWO + DESSERT_TWO;
            double TAX = SUBTOTAL_ONE + SUBTOTAL_TWO * TAXRATE;
            double TIP = SUBTOTAL_ONE + SUBTOTAL_TWO * TIP_PERCENT;
            double TOTAL = SUBTOTAL_ONE + SUBTOTAL_TWO + TAX + TIP;
            double TAX_ONE = SUBTOTAL_ONE * TAXRATE;
            double TIP_ONE = SUBTOTAL_ONE * TIP_PERCENT;
            double TOTAL_ONE = SUBTOTAL_ONE + TAX_ONE + TIP_ONE;
            double TAX_TWO = SUBTOTAL_TWO * TAXRATE;
            double TIP_TWO = SUBTOTAL_TWO * TIP_PERCENT;
            double TOTAL_TWO = SUBTOTAL_TWO + TAX_TWO + TIP_TWO;
            double TOTAL_ADD = TOTAL_ONE + TOTAL_TWO;
            int SPLITTING = 2;
            double SPLIT = TOTAL_ADD / SPLITTING;

            Console.WriteLine("First Total: " + "{0:N2}", TOTAL_ONE);
            Console.WriteLine("Press Enter for Second Total: ");
            Console.ReadLine();
            Console.WriteLine("Second Total: " + "{0:N2}", TOTAL_TWO);
            Console.WriteLine("Press Enter for Split Cost");
            Console.ReadLine();
            Console.WriteLine("Total Due for Each: " + "{0:N2}", SPLIT);
            Console.ReadLine();
        }
    }
}