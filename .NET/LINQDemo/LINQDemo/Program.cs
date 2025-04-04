using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSelect a LINQ Operation:");
            Console.WriteLine("1. LINQ to Array");
            Console.WriteLine("2. LINQ to XML");
            Console.WriteLine("3. LINQ to SQL");
            Console.WriteLine("4. LINQ to Collection");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    LinqToArray.Execute();
                    break;
                case "2":
                    LinqToXML.Execute();
                    break;
                case "3":
                    LinqToSQL.Execute();
                    break;
                case "4":
                    LinqToCollection.Execute();
                    break;
                case "5":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }
        }
    }
}

