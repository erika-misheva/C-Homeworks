using System;

namespace secondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter four numbers");
            string fisrtNumber = Console.ReadLine();
            double.TryParse(fisrtNumber, out double firstParsedNumber);

            string secondNumber = Console.ReadLine();
            double.TryParse(secondNumber, out double secondParsedNumber);

            string thirdNumber = Console.ReadLine();
            double.TryParse(thirdNumber, out double thirdParsedNumber);

            string fourthNumber = Console.ReadLine();
            double.TryParse(fourthNumber, out double fourthParsedNumber);

            double sumOfFourNumbers = firstParsedNumber + secondParsedNumber + thirdParsedNumber + fourthParsedNumber;

            double avarage = sumOfFourNumbers / 4;
            Console.WriteLine($"The avarege of the four numbers is {avarage}");
        }
    }
}
