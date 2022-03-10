using System;

namespace firstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers");
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            double.TryParse(firstNumber, out double parsedNumber);
            Console.WriteLine(parsedNumber);

            double.TryParse(secondNumber, out double secondParsedNumber);
            Console.WriteLine(secondParsedNumber);

            Console.WriteLine("What operation would you like to use?");
            string operation = Console.ReadLine();
            double result = default;

            switch (operation)
            {
                case "+" :
                    result = parsedNumber + secondParsedNumber;
                    break;
                case "-":
                    result = parsedNumber - secondParsedNumber;
                    break;
                case "*":
                    result = parsedNumber * secondParsedNumber;
                    break;
                case "/":
                    result = parsedNumber / secondParsedNumber;
                    break;
                default:
                    Console.WriteLine("You entered an invalid input");
                    break;
            }

            Console.WriteLine($"The result is {result}");
        }
    }
}
