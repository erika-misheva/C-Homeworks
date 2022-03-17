using System;

namespace fourthExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] integerArrey = { 5, 56, 7, 8, 61, 22, 5, 10, 9, 17 };
            int max = integerArrey[0];
            int min = integerArrey[0];

            for (int i = 0; i < integerArrey.Length; i++)
            {
                if (integerArrey[i] > max)
                {
                    max = integerArrey[i];
                }
                if (integerArrey[i] < min)
                {
                    min = integerArrey[i];
                }
            }
            Console.WriteLine($"The maximum in the array is {max} and the minimum is {min}");
        }
    }
}
