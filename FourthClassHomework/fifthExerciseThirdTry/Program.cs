using System;

namespace fifthExerciseThirdTry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how many elements should the array have?");

            int.TryParse(Console.ReadLine(), out int inputNumber);
            int[] numberArray = new int[inputNumber];

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.WriteLine("Please enter a whole number");
                int.TryParse(Console.ReadLine(), out numberArray[i]);

            }
            int threePairCounter = 0;
            for (int i = 0; i < numberArray.Length - 1; i++)
            {
                bool previousIsThree = numberArray[i] == 3;
                bool nextIsThree = numberArray[i + 1] == 3;

                if (previousIsThree && nextIsThree) {

                    threePairCounter++;
                };
            }

            Console.WriteLine($"There were {threePairCounter} times three in a row");
        }
    }
}
