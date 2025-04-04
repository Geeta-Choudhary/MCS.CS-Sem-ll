using System;
using System.IO;

class TextFileOperations
{
    static string filePath = "SampleTextFile.txt";

    public static void WriteToFile()
    {
        Console.Write("Enter text to write to file: ");
        string content = Console.ReadLine();
        File.WriteAllText(filePath, content);
        Console.WriteLine("File written successfully.");
    }

    public static void AppendToFile()
    {
        Console.Write("Enter text to append: ");
        string content = Console.ReadLine();
        File.AppendAllText(filePath, content + Environment.NewLine);
        Console.WriteLine("Text appended successfully.");
    }

    public static void ReadFromFile()
    {
        if (File.Exists(filePath))
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Contents:");
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}

