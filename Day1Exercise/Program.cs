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

            // using string interpolation
            Console.WriteLine("Bahaha, your identity has been stolen! " +
                $"My name is now {name}, I am {age} years old, and I am from {homeTown}!!!");
        }
    }
}
