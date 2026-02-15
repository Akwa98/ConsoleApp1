// See https://aka.ms/new-console-template for more information

using System;
using System.Numerics;

namespace MyNamespace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to these simple calculator!");
            bool isRunning = true;
            while (isRunning)
            {

                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                string? operation;
                while (true)
                {
                    Console.Write("Enter an operator (+, -, *, /) or 'exit' to quit: ");
                    operation = Console.ReadLine()?.ToLower();

                    if (operation is "+" or "-" or "*" or "/" or "exit")
                        break;

                    Console.WriteLine("Invalid operator. Please try again.");
                }
                if (string.Equals(operation, "EXIT", StringComparison.OrdinalIgnoreCase))
                {
                    isRunning = false;
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                if (operation == "+")
                {
                    Console.WriteLine($"The sum of {num1} and {num2} is: {Add(num1, num2)}");
                }
                else if (operation == "-")
                {
                    Console.WriteLine($"The difference of {num1} and {num2} is: {Subtract(num1, num2)}");
                }
                else if (operation == "*")
                {
                    Console.WriteLine($"The product of {num1} and {num2} is: {Multiply(num1, num2)}");
                }
                else if (operation == "/")
                {
                    try
                    {
                        Console.WriteLine($"The quotient of {num1} and {num2} is: {Divide(num1, num2)}");
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Please enter valid numbers, not text. {ex.Message}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"This is an invalid action {ex.Message}");
                    }
                }
                else if (operation == "exit")
                {
                    isRunning = false;
                    break;
                }
                else
                {
                    Console.WriteLine("invalid operator");
                }

            }

        }
        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Subtract(double a, double b)
        {
            return a - b;
        }
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Division by zero is not allowed.");
            }
            else if (double.IsNaN(a) || double.IsNaN(b))
            {
                throw new FormatException("Input cannot be an Alphabet.");
            }
            return a / b;
        }

    }
}

