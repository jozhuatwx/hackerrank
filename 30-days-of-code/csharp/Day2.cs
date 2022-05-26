using System;

namespace Day2
{
    class Day2
    {
        static int TotalCost(double meal_cost, int tip_percent, int tax_percent) {
            // return total cost
            return Convert.ToInt32(meal_cost + (meal_cost * tip_percent / 100) + (meal_cost * tax_percent / 100));
        }

        static void Main(string[] args)
        {
            // initialisation
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            int tip_percent = Convert.ToInt32(Console.ReadLine());
            int tax_percent = Convert.ToInt32(Console.ReadLine());

            // print total cost statement
            Console.WriteLine(TotalCost(meal_cost, tip_percent, tax_percent));
        }
    }
}
