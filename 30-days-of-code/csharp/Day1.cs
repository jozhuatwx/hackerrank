using System;

namespace Day1
{
    class Day1
    {
        static void Main(string[] args)
        {
            // initialisation
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // read input
            int i2 = Convert.ToInt32(Console.ReadLine());
            double d2 = Convert.ToDouble(Console.ReadLine());
            string s2 = Console.ReadLine();

            // print sum statement
            Console.WriteLine(i + i2);
            Console.WriteLine(String.Format("{0:N1}", d + d2));
            Console.WriteLine(s + s2);
        }
    }
}
