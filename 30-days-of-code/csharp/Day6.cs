using System;

namespace Day6
{
    class Day6
    {
        static void Main(string[] args)
        {
            // read total input strings
            int times = Convert.ToInt32(Console.ReadLine());

            // loop number of times
            for (int i = 0; i < times; i++)
            {
                // read input
                string input = Console.ReadLine();

                // print even characters
                for (int j = 0; j < input.Length; j = j + 2)
                    Console.Write(input[j]);

                // print spacing
                Console.Write(" ");

                // print odd characters
                for (int j = 1; j < input.Length; j = j + 2)
                    Console.Write(input[j]);
                
                // print new line
                Console.WriteLine();
            }
        }
    }
}
