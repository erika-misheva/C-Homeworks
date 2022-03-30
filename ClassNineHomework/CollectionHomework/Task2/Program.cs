using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a list of ten numbers.
            //Use LINQ to select in a list of the squares of all the numbers in the list from above.

            List<double> doubleList = new List<double>()
            {
                2.5,6,4.0,7,5,12,6,10,3.5,11
            };


            List<double> squareNumbers = doubleList.Select(i => Math.Pow(i, 2)).ToList();


            for (int i = 0; i < squareNumbers.Count; i++)
            {
                for (int j = 0; j < doubleList.Count; j++)
                {
                    if (j == i)
                    {
                        Console.WriteLine($"The square of the number {doubleList[j]} is : {squareNumbers[i]}");
                    }

                }
            }

        }
    }
}
