using System;
using System.Linq;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n==== C# Program Menu ====");
            Console.WriteLine("1. Shuffle First and Last Character of String");
            Console.WriteLine("2. Sum of Digits of an Integer");
            Console.WriteLine("3. Check Palindrome (Without Recursion)");
            Console.WriteLine("4. Check Palindrome (With Recursion)");
            Console.WriteLine("5. Square Root Calculation with Exception Handling");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice (1-6): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ShuffleString();
                    break;
                case "2":
                    SumOfDigits();
                    break;
                case "3":
                    PalindromeWithoutRecursion();
                    break;
                case "4":
                    PalindromeWithRecursion();
                    break;
                case "5":
                    SquareRootWithException();
                    break;
                case "6":
                    Console.WriteLine("Exiting program. Thank you!");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please enter a number between 1-6.");
                    break;
            }
        }
    }

    static void ShuffleString()
    {
        Console.Write("\nEnter a string: ");
        string input = Console.ReadLine();

        if (input.Length < 2)
        {
            Console.WriteLine("String must have at least two characters.");
            return;
        }

        string shuffled = input[^1] + input.Substring(1, input.Length - 2) + input[0];
        Console.WriteLine("Shuffled String: " + shuffled);
    }

    static void SumOfDigits()
    {
        Console.Write("\nEnter an integer: ");
        string input = Console.ReadLine();
        int sum = 0;

        foreach (char c in input)
        {
            if (char.IsDigit(c))
                sum += c - '0';
            else
            {
                Console.WriteLine("Invalid input! Please enter only digits.");
                return;
            }
        }

        Console.WriteLine("Sum of digits: " + sum);
    }

    static void PalindromeWithoutRecursion()
    {
        Console.Write("\nEnter a number: ");
        string num = Console.ReadLine();

        string reversed = new string(num.Reverse().ToArray());

        if (num == reversed)
            Console.WriteLine("It is a Palindrome.");
        else
            Console.WriteLine("Not a Palindrome.");
    }

    static bool IsPalindrome(string s, int start, int end)
    {
        if (start >= end)
            return true;

        return (s[start] == s[end]) && IsPalindrome(s, start + 1, end - 1);
    }

    static void PalindromeWithRecursion()
    {
        Console.Write("\nEnter a number: ");
        string num = Console.ReadLine();

        if (IsPalindrome(num, 0, num.Length - 1))
            Console.WriteLine("It is a Palindrome.");
        else
            Console.WriteLine("Not a Palindrome.");
    }

    static void SquareRootWithException()
    {
        try
        {
            Console.Write("\nEnter a number: ");
            double num = Convert.ToDouble(Console.ReadLine());

            if (num < 0)
                throw new ArgumentException("Cannot calculate square root of a negative number.");

            double result = Math.Sqrt(num);
            Console.WriteLine("Square Root: " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

