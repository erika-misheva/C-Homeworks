using System;

namespace secondExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Take a sentence as input and find its words.

            Console.WriteLine("Please enter a sentece!");
            string sentence = Console.ReadLine();

            var words = sentence.Split(' ');
            Array.ForEach(words, Console.WriteLine);

        }
    }
}
