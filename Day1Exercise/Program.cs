using System;

namespace Day1Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to the Identity Stealer!");

            //Exercise: Find out name, age, hometown. Display the info back to them.
            Console.WriteLine("May I have your name?");
            string name = Console.ReadLine();

            Console.WriteLine("May I have your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your hometown?");
            string homeTown = Console.ReadLine();

            Console.WriteLine("What is your favorite food?");
            string food = Console.ReadLine();

            // using string interpolation
            Console.WriteLine( $"Your name is {name}, you are {age} years old, you are from {homeTown}," +
                $" and your favorite food is {food}!");

            Console.WriteLine("Please enter something:");
            Console.WriteLine(Console.ReadLine());

            Console.WriteLine("Please enter a number:");
            double num = double.Parse(Console.ReadLine());
            Console.WriteLine(num + 1);

            Console.WriteLine("Please enter a number:");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine(num2 + .5);

            Console.WriteLine("Please enter first number:");
            double num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            double num4 = double.Parse(Console.ReadLine());
            Console.WriteLine(num3 + num4);

            Console.WriteLine("Please enter a number:");
            double num5 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter next number:");
            double num6 = double.Parse(Console.ReadLine());
            Console.WriteLine(num5 * num6);

        }
    }
}
