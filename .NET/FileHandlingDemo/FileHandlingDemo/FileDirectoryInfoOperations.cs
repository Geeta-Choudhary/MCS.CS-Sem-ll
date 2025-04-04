using System;
using System.IO;

class FileDirectoryInfoOperations
{
    public static void GetFileInfo(string path)
    {
        if (File.Exists(path))
        {
            FileInfo fileInfo = new FileInfo(path);
            Console.WriteLine($"File Name: {fileInfo.Name}");
            Console.WriteLine($"File Size: {fileInfo.Length} bytes");
            Console.WriteLine($"Created On: {fileInfo.CreationTime}");
            Console.WriteLine($"Last Accessed: {fileInfo.LastAccessTime}");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public static void GetDirectoryInfo(string path)
    {
        if (Directory.Exists(path))
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            Console.WriteLine($"Directory Name: {dirInfo.Name}");
            Console.WriteLine($"Created On: {dirInfo.CreationTime}");
            Console.WriteLine($"Number of Files: {dirInfo.GetFiles().Length}");
            Console.WriteLine($"Number of Subdirectories: {dirInfo.GetDirectories().Length}");
        }
        else
        {
            Console.WriteLine("Directory not found.");
        }
    }
}

