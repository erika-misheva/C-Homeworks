using System;

namespace thirdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers");
            string fisrtNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            double.TryParse(fisrtNumber, out double firstNumberParsed);
            Console.WriteLine($"Before swapping the first number is {firstNumberParsed}");
            double firstNumberMemory = firstNumberParsed;

            double.TryParse(secondNumber, out double secondParsedNumber);
            Console.WriteLine($"Before swapping the second number is {secondParsedNumber}");

            //Swaping
            firstNumberParsed = secondParsedNumber;
            secondParsedNumber = firstNumberMemory;

            Console.WriteLine($"After Swapping: the first number is {firstNumberParsed}, the second number is {secondParsedNumber}");

        }
    }
}
