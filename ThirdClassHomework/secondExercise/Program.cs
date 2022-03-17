using System;

namespace secondExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //console application called SumOfEven
            Console.WriteLine("Please enter six numbers for an array!");
            int[] integerArray = new int[6];
            for (int i = 0; i < integerArray.Length; i++)
            {
                //integerArray[i] = Convert.ToInt32(Console.In.ReadLine()); (this is one way to fill the array)
                int.TryParse(Console.ReadLine(), out integerArray[i]);

            }
            int sumOfEvenNumbers = 0;
            foreach (int number in integerArray)
            {
                if (number % 2 == 0)
                {
                    sumOfEvenNumbers += number;
                }
            }
            Console.WriteLine($"The sum of the even numbers is {sumOfEvenNumbers}");
        }
    }
}
