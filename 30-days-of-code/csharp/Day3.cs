using System;

namespace Day3
{
    class Day3
    {
        static string conditionalStatement(int i)
        {
            // return conditional statement
            if (i % 2 != 0)
                return "Weird";
            if (i > 20)
                return "Not Weird";
            if (i >= 6)
                return "Weird";

            return "Not Weird";
        }

        static void Main(string[] args)
        {
            // initialisation
            int i = Convert.ToInt32(Console.ReadLine());

            // print conditional statement
            Console.WriteLine(conditionalStatement(i));
        }
    }
}
