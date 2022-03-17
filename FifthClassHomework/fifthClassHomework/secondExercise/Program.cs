using System;


namespace secondExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name");
            string fName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            string lName = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            int.TryParse(Console.ReadLine(), out int age);

            Person inputPerson = new Person(fName, lName, age);

            Console.WriteLine(inputPerson.GetPersonStats());

        }
    }
}
