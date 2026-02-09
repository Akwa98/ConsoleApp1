// See https://aka.ms/new-console-template for more information

using System;
using System.Numerics;

namespace MyNamespace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (true)
            {
                string? operation = null;
                while (true)
                {
                    Console.WriteLine("Enter an operator (+, -, *, /) or 'exit' to quit: ");
                    operation = Console.ReadLine();
                    if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "EXIT" || operation == "exit")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid operator. Please try again.");
                    }
                }
                if (string.Equals(operation, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    isRunning = false;
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }


                Console.WriteLine("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (operation == "+")
                {
                    Console.WriteLine($"the answer is {num1 + num2}");
                }
                else if (operation == "-")
                {
                    Console.WriteLine($"the answer is {num1 - num2}");
                }
                else if (operation == "*")
                {
                    Console.WriteLine($"the answer is {num1 * num2}");
                }
                else if (operation == "/")
                {
                    Console.WriteLine($"the answer is {num1 / num2}");
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


            Console.ReadLine();

        }
    } 
}

