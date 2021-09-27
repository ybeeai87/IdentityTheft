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
        }
    }
}
