using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}

public class Assignment7
{
    public static void Main(string[] args)
    {   //creating the list
        List<Product> products = new List<Product>()
        {
            new Product { Name = "Laptop", Category = "Electronics", Price = 1200.00m },
            new Product { Name = "Mouse", Category = "Electronics", Price = 25.00m },
            new Product { Name = "Book", Category = "Books", Price = 20.00m },
            new Product { Name = "T-Shirt", Category = "Apparel", Price = 30.00m },
            new Product { Name = "Ebook", Category = "Books", Price = 25.00m },
            new Product { Name = "Keyboard", Category = "Electronics", Price = 75.00m },
            new Product { Name = "Jeans", Category = "Apparel", Price = 25.00m }
        };

        // LINQ to group by category and calculate the average price
        var averagePricesByCategory = products
            .GroupBy(product => product.Category)
            .Select(group => new
            {
                Category = group.Key,
                AveragePrice = group.Average(product => product.Price)
            });

        Console.WriteLine("Average Prices by Category:");

        // Loop through the grouped categories and print the result
        foreach (var categoryPrice in averagePricesByCategory)
        {
            Console.WriteLine($"{categoryPrice.Category}: {categoryPrice.AveragePrice:F2}");
        }
    }
}


