using System;

namespace thirdExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter whole number!");
            int.TryParse(Console.ReadLine(), out var numberInput);

            for (int i = 0; i < numberInput; i++)
            {
                if (i % 5 == 0 && i != 80) //80 se deli so 5 ako go nema vtoriot uslov nikogas nema da vleze vo vtoriot if
                {
                    continue;
                }
                if (i == 80)
                {
                    Console.WriteLine("You reached the limit!");
                    break;
                }
                Console.WriteLine(i);

            }
        }
    }
}
