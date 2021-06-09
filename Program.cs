using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello what is ur name!");

            var name = Console.ReadLine();

            Console.WriteLine($"Hello {name}");

            Console.WriteLine("What year is it?");

            var year = int.Parse(Console.ReadLine())

            Console.WriteLine($"Correct! The year is {year}");
        }
    }
}
