using System;
using System.Collections.Generic;
using System.Linq;

class LinqToCollection
{
    public static void Execute()
    {
        List<Student> students = new List<Student>
        {
            new Student { ID = 1, Name = "Alice", Age = 22 },
            new Student { ID = 2, Name = "Bob", Age = 24 },
            new Student { ID = 3, Name = "Charlie", Age = 21 }
        };

        var filteredStudents = students.Where(s => s.Age > 22).Select(s => s.Name);

        Console.WriteLine("Students older than 22:");
        foreach (var name in filteredStudents)
        {
            Console.WriteLine(name);
        }
    }
}

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

