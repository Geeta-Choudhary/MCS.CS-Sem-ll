using System;

namespace MyOperations
{
    // Custom Exception Class
    public class MyCustomException : Exception
    {
        public int ErrorCode { get; }

        public MyCustomException(int errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }

        public override string ToString()
        {
            return $"Error Code: {ErrorCode}, Message: {Message}";
        }
    }

    public class Operations
    {
        // Addition
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        // Subtraction
        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        // Multiplication
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        // Division with exception handling
        public static double Divide(double numerator, double denominator)
        {
            try
            {
                if (denominator == 0)
                    throw new DivideByZeroException();

                return numerator / denominator;
            }
            catch (DivideByZeroException)
            {
                throw new MyCustomException(101, "Attempted to divide by zero. Please provide a non-zero denominator.");
            }
        }

        // Array Index Access with exception handling
        public static int GetArrayElement(int[] arr, int index)
        {
            try
            {
                return arr[index];
            }
            catch (IndexOutOfRangeException)
            {
                throw new MyCustomException(102, "Array index out of range. Please enter a valid index.");
            }
        }
    }
}

