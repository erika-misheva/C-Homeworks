using System;

namespace firstExercise
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your date of birth, enter first the month, than the day and the year");
            AgeCalculator(Console.ReadLine());
            static int AgeCalculator (string dateOfBirth)
            {
                DateTime parsedDateOfBirth = DateTime.Parse(dateOfBirth);
                int age = 0;
                age = DateTime.Now.Subtract(parsedDateOfBirth).Days;
                age = age / 365;
                Console.WriteLine($"You are {age} years old");
                return age; 
            }
        }
    }
}
