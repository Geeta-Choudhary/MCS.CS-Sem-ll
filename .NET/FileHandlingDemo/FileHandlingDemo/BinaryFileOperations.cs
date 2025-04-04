using System;
using System.IO;

class BinaryFileOperations
{
    static string binaryFilePath = "SampleBinaryFile.dat";

    public static void WriteBinaryFile()
    {
        Console.Write("Enter a number to write to binary file: ");
        int number = Convert.ToInt32(Console.ReadLine());

        using (BinaryWriter writer = new BinaryWriter(File.Open(binaryFilePath, FileMode.Create)))
        {
            writer.Write(number);
            Console.WriteLine("Binary file written successfully.");
        }
    }

    public static void ReadBinaryFile()
    {
        if (File.Exists(binaryFilePath))
        {
            using (BinaryReader reader = new BinaryReader(File.Open(binaryFilePath, FileMode.Open)))
            {
                int number = reader.ReadInt32();
                Console.WriteLine($"Binary file contains: {number}");
            }
        }
        else
        {
            Console.WriteLine("Binary file does not exist.");
        }
    }
}

