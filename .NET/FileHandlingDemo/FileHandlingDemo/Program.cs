using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSelect an operation:");
            Console.WriteLine("1. Write to Text File");
            Console.WriteLine("2. Append to Text File");
            Console.WriteLine("3. Read from Text File");
            Console.WriteLine("4. Write to Binary File");
            Console.WriteLine("5. Read from Binary File");
            Console.WriteLine("6. Get File Info");
            Console.WriteLine("7. Get Directory Info");
            Console.WriteLine("8. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    TextFileOperations.WriteToFile();
                    break;
                case "2":
                    TextFileOperations.AppendToFile();
                    break;
                case "3":
                    TextFileOperations.ReadFromFile();
                    break;
                case "4":
                    BinaryFileOperations.WriteBinaryFile();
                    break;
                case "5":
                    BinaryFileOperations.ReadBinaryFile();
                    break;
                case "6":
                    Console.Write("Enter file path: ");
                    string filePath = Console.ReadLine();
                    FileDirectoryInfoOperations.GetFileInfo(filePath);
                    break;
                case "7":
                    Console.Write("Enter directory path: ");
                    string dirPath = Console.ReadLine();
                    FileDirectoryInfoOperations.GetDirectoryInfo(dirPath);
                    break;
                case "8":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }
        }
    }
}
