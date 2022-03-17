using System;

namespace firstExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers");

            bool firstSucces = int.TryParse(Console.ReadLine(), out int firstNumber);
            bool secondSucces = int.TryParse(Console.ReadLine(), out int secondNumber);

            if (firstSucces && secondSucces)
            {
                if (firstNumber % 2 == 0 && secondNumber % 2 == 0)
                {
                    int sumForEven = firstNumber + secondNumber;
                    Console.WriteLine($"The Numbers are even. The operation and the result are {firstNumber} + {secondNumber} = {sumForEven}");
                }
                else if ((firstNumber % 2 != 0 && secondNumber % 2 == 0) || (firstNumber % 2 == 0 && secondNumber % 2 != 0))
                {
                    int differanceForOddEven = firstNumber - secondNumber;
                    Console.WriteLine($"One of the numbers is odd. The operation and the result are {firstNumber} - {secondNumber} = {differanceForOddEven}");
                }
                else
                {
                    int multiplicationForOdd = firstNumber * secondNumber;
                    Console.WriteLine($"The two numbers are odd.The operation and the result are {firstNumber} * {secondNumber} = {multiplicationForOdd}");
                }
            }
            else
            {
                Console.WriteLine("You have entered invalid input! You must enter two whole numbers");
            }
        }
    }
}
