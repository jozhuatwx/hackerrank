using System;

namespace Day5
{
    class Day5
    {
        static void Main(string[] args)
        {
            // read input
            int input = Convert.ToInt32(Console.ReadLine());

            // print multiplication table
            for (int i = 1; i < 11; i++)
                Console.WriteLine(input + " x " + i + " = " + input * i);
        }
    }
}
