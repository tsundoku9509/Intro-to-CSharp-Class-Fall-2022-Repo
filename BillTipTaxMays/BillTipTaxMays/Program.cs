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

        }
    }
}