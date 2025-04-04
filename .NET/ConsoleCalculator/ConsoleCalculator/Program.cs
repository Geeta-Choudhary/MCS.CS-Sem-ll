using System;
using MyOperations; // Import the class library

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Interactive Calculator!");

            while (true)
            {
                Console.WriteLine("\nSelect an operation:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");
                Console.WriteLine("5. Access Array Element");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice (1-6): ");

                string choice = Console.ReadLine();

                // Validate input choice before proceeding
                if (!IsValidChoice(choice))
                {
                    Console.WriteLine("Invalid choice! Please select a valid option (1-6).");
                    continue;
                }

                if (choice == "6")
                {
                    Console.WriteLine("Exiting Calculator. Thank you!");
                    break;
                }

                if (choice == "5") // Handle array element access
                {
                    HandleArrayOperation();
                    continue;
                }

                try
                {
                    Console.Write("\nEnter first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;

                    switch (choice)
                    {
                        case "1":
                            result = Operations.Add(num1, num2);
                            Console.WriteLine($"Result: {num1} + {num2} = {result}");
                            break;
                        case "2":
                            result = Operations.Subtract(num1, num2);
                            Console.WriteLine($"Result: {num1} - {num2} = {result}");
                            break;
                        case "3":
                            result = Operations.Multiply(num1, num2);
                            Console.WriteLine($"Result: {num1} * {num2} = {result}");
                            break;
                        case "4":
                            result = Operations.Divide(num1, num2);
                            Console.WriteLine($"Result: {num1} / {num2} = {result}");
                            break;

                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Invalid input! Please enter numeric values.");
                }
                catch (MyCustomException ex)
                {
                    Console.WriteLine($"Custom Exception Caught: {ex}");
                }
            }
        }

        static bool IsValidChoice(string input)
        {
            return input == "1" || input == "2" || input == "3" || input == "4" || input == "5" || input == "6";
        }

        static void HandleArrayOperation()
        {
            try
            {
                int[] numbers = { 10, 20, 30, 40, 50 };

                // Display the array
                Console.WriteLine("\nArray Elements:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Index {i}: {numbers[i]}");
                }

                Console.Write("\nEnter array index to retrieve: ");
                int index = Convert.ToInt32(Console.ReadLine());

                int value = Operations.GetArrayElement(numbers, index);
                Console.WriteLine($"Value at index {index}: {value}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input! Please enter a valid number.");
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine($"Custom Exception Caught: {ex}");
            }
        }
    }
}

