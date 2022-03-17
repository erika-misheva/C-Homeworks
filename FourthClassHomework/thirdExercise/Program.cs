using System;

namespace thirdExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sumOfDigitsFromInput(Console.ReadLine());

            //Create a function that takes a number as input. This method should return the sum of the digits in the number.
            static int sumOfDigitsFromInput(string input)
            {
                bool Succes = int.TryParse(input, out int number);
                int sumOfDigits = 0;
                if (!Succes)
                {
                    Console.WriteLine("Invalid input");
                    return 0;
                }
                else
                {
                    while (number > 0)
                    {
                        int digit;
                        Math.DivRem(number, 10, out digit);
                        sumOfDigits += digit;
                        number /= 10;
                    }
                    Console.WriteLine($"The sum of the digits is {sumOfDigits}");
                    return sumOfDigits;
                }
            }
        }
    }
}
