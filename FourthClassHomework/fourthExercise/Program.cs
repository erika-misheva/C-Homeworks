using System;

namespace fourthExercise
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers and one operator");

            Console.WriteLine("Enter the first number");
            string firstNumberInput = Console.ReadLine();

            Console.WriteLine("Please enter the second number");
            string secondNumberInput = Console.ReadLine();

            Console.WriteLine("Plese enter one of the following operetor : +, -, *, /");
            string operation = Console.ReadLine();

            Calculator(firstNumberInput, secondNumberInput, operation);

            static int Sum(int num1, int num2)
            {
                return num1 + num2;
            }
            static int Differance(int num1, int num2)
            {
                return num1 - num2;
            }
            static int multiplication(int num1, int num2)
            {
                return num1 * num2;
            }
            static int divison(int num1, int num2)
            {
                return num1 / num2;
            }

            static void Calculator(string number1, string number2, string operation)
            {
                bool succes1 = int.TryParse(number1, out int num1);
                bool succes2 = int.TryParse(number2, out int num2);
                if (succes1 && succes2)
                {
                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine($"The sum of the numbers is {Sum(num1, num2)}");
                            break;
                        case "-":
                            Console.WriteLine($"The differance of the numbers is {Differance(num1, num2)}");
                            break;
                        case "*":
                            Console.WriteLine($"The multiplication of the numbers is {multiplication(num1, num2)}");
                            break;
                        case "/":
                            Console.WriteLine($"The division of the numbers is {divison(num1, num2)}");
                            break;
                        default:
                            Console.WriteLine("Something wnt wrong, Invalid input");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Something went wrong,invalid input. You must enter two whole numbers and one valid operator");
                }

            }


        }
    }
}
