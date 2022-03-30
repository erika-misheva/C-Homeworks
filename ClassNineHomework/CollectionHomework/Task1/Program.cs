using System;
using System.Collections;
using System.Collections.Generic;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Give the user an option to input 5 numbers
            //Store all numbers in a QUEUE
            //When the user is done adding numbers print the number in the order that the user entered them from the QUEUE

            Queue<int> intQueue = new Queue<int>();
            Console.WriteLine("Please enter five whole numbers");
            for (int i = 0; i < 5; i++)
            {
                bool succes = int.TryParse(Console.ReadLine(), out int Number);

                if (!succes)
                {
                    Console.WriteLine("The entered input isn't valid number. Try again.");
                    i--;
                }
                else
                {
                    intQueue.Enqueue(Number);
                }
            }

            foreach (int integer in intQueue)
            {
                Console.WriteLine(integer);
            }



        }
    }
}
