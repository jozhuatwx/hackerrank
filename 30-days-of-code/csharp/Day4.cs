using System;

namespace Day4
{
    class Person
    {
        // properties
        int age;

        // constructor
        Person(int age)
        {
            // check if valid age
            if (age >= 0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("Age is not valid, setting age to 0.");
                this.age = 0;
            }
        }

        void YearPasses()
        {
            // increment age
            age++;
        }

        string AmIOld()
        {
            // return age statement
            if (age < 13)
                return "You are young.";
            if (age < 18)
                return "You are a teenager.";

            return "You are old.";
        }
    }

    class Day4
    {
        static void Main(string[] args)
        {
            // read total input numbers
            int times = Convert.ToInt32(Console.ReadLine());

            // loop number of times
            for (int i = 0; i < times; i++)
            {
                // instantiate a person
                Person p = new Person(Convert.ToInt32(Console.ReadLine()));

                // print age statement
                Console.WriteLine(p.AmIOld());

                // increment person age
                for (int j = 0; j < 3; j++)
                    p.YearPasses();

                // print age statement
                Console.WriteLine(p.AmIOld());
            }
        }
    }
}
