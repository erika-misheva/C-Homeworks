using System;

namespace fifthExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an array of integers.Get the number of elements and the values of the elements from input.
            //Find how many times there are two 3 next to each other.

            int[] arrayOfNumbers = new int[0];

            int counter = 0;
            while (true)
            {
                Console.WriteLine("Enter an whole number");
                bool succes = int.TryParse(Console.ReadLine(), out int number);
                if (succes)
                {
                    Array.Resize(ref arrayOfNumbers, arrayOfNumbers.Length + 1);
                    arrayOfNumbers[counter] = number;
                    counter++;
                }
                else
                {
                    Console.WriteLine("You must enter whole number!");
                    continue;
                }
                Console.WriteLine("Do you want to continue?Enter no to stop and yes to continue!");
                string response = Console.ReadLine();
                if (response == "No" || response == "no")
                {
                    break;
                }
                
            }
            int counterForThree = 1;
            int ThreeNextToEachother = 0;
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {

                if (arrayOfNumbers[i] == 3 && counterForThree == 1)
                {
                    counterForThree++;
                }
                else if (arrayOfNumbers[i] == 3 && counterForThree > 1)
                {
                    counterForThree++;
                    ThreeNextToEachother++;
                }
                else
                {
                    counterForThree = 1;

                }

            }
            if (ThreeNextToEachother != 0)
            {
                Console.WriteLine($"{ThreeNextToEachother} times there are threes next to each other");
            }
            else 
            {
                Console.WriteLine("There aren't threes next to each other");
            }


        }
    }
}
