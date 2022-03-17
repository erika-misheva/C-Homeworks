using System;

namespace fifthExerciseSecondTry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how many elements should the array have?");

            int.TryParse(Console.ReadLine(), out int parsedInputNumber);
            int[] numberArray = new int[parsedInputNumber];

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine("Please enter a whole number");
                int.TryParse(Console.ReadLine(), out numberArray[i]);
               
            }
            int counter = 1; //po default zemame deka ima edna trojka i koga ke se smeni na dve ja menuvame vrednosta na drugiot brojac
            int threePairCount = 0;
          
            for (int i = 0; i < numberArray.Length; i++)
            { 
                if (numberArray[i] == 3 && counter == 1)
                {
                    counter++;
                }
                else if (numberArray[i] == 3 && counter > 1)
                {
                    threePairCount++;

                }
                else
                {
                    counter = 1;
                }

            }
            if (threePairCount >= 1)
            {
                Console.WriteLine($"{threePairCount} times there are threes next to each other.");
            }
            else 
            {
                Console.WriteLine("There aren't threes next to each other");
            }

        }
    }
}
