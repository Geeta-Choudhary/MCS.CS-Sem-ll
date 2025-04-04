using System;
using System.Linq;

class LinqToArray
{
    public static void Execute()
    {
        int[] numbers = { 5, 8, 2, 10, 3, 7, 6 };

        var evenNumbers = numbers.Where(n => n % 2 == 0).OrderBy(n => n);

        Console.WriteLine("Even numbers in sorted order:");
        foreach (var num in evenNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

