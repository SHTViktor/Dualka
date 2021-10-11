using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {

        tryAgain:
            Console.Write("Enter side of the square: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("S = " + (a * a));
                Console.WriteLine("P = " + (a * 4));
            }
            else
            {
                Console.WriteLine("\nSide must be greater than 0");
                goto tryAgain;
            }

            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine($"How old are you, {name}? ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your name is {name}, you are {age} years old");

            double pi = 3.14;

        OneMoreTime:
            Console.Write("Enter radius of a circle: ");
            double r = Convert.ToDouble(Console.ReadLine());

            if (r > 0)
            {
                Console.WriteLine("l = " + (2 * pi * r));
                Console.WriteLine("S = " + (pi * r * r));
                Console.WriteLine("V = " + (4.0 / 3.0 * pi * r * r * r));
            }
            else
            {
                Console.WriteLine("\nRadius must be greater than 0");
                goto OneMoreTime;
            }

            Console.ReadKey();
        }
    }
}
