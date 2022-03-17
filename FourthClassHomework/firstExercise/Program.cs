using System;

namespace firstExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Take one string from the input and print its last 5 characters!");

            Console.WriteLine("Enter a word!");

            string input = Console.ReadLine();

            string output = input.Substring(input.Length - 5);

            Console.WriteLine(output);
        }
    }
}
