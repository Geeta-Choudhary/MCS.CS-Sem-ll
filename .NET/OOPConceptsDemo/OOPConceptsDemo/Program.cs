using System;

interface IEmployee
{
    void DisplayDetails();
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine("Person Constructor Called");
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Person: {Name}, Age: {Age}");
    }

    static Person()
    {
        Console.WriteLine("Static Constructor: Person Class Initialized");
    }

    private Person()
    {
        Console.WriteLine("Private Constructor Called");
    }
}

class Employee : Person, IEmployee
{
    public int EmployeeID { get; set; }
    public string Department { get; set; }

    public Employee(string name, int age, int employeeID, string department)
        : base(name, age)
    {
        EmployeeID = employeeID;
        Department = department;
        Console.WriteLine("Employee Constructor Called");
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Employee: {Name}, Age: {Age}, Employee ID: {EmployeeID}, Department: {Department}");
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Displaying Employee Details...");
        ShowInfo();
    }

    public new void ShowInfo(string prefix)
    {
        Console.WriteLine($"{prefix} Employee: {Name}, Age: {Age}, Employee ID: {EmployeeID}, Department: {Department}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Creating Employee Object...\n");
        Employee emp = new Employee("John Doe", 30, 101, "IT");

        Console.WriteLine("\nCalling Virtual Method:");
        emp.ShowInfo();

        Console.WriteLine("\nCalling Overloaded Method:");
        emp.ShowInfo("Info:");

        Console.WriteLine("\nCalling Interface Method:");
        emp.DisplayDetails();
    }
}

