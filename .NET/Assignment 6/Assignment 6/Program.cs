using System;
using System.Collections.Generic;
using System.Linq;

//Creating the customer class 
public class Customer
{
    public int CustomerId { get; set; }
    public string Name { get; set; }
}

public class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }
}

public class Assignment6
{
    public static void Main(string[] args)
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer { CustomerId = 1, Name = "Alice" },
            new Customer { CustomerId = 2, Name = "Bob" },
            new Customer { CustomerId = 3, Name = "Charlie" },
            new Customer { CustomerId = 4, Name = "David" }
        };

        List<Order> orders = new List<Order>()
        {
            new Order { OrderId = 101, CustomerId = 1, OrderDate = DateTime.Now.AddDays(-5) },
            new Order { OrderId = 201, CustomerId = 2, OrderDate = DateTime.Now.AddDays(-10) },
            new Order { OrderId = 103, CustomerId = 1, OrderDate = DateTime.Now.AddDays(-2) },
            new Order { OrderId = 301, CustomerId = 4, OrderDate = DateTime.Now.AddDays(-1) },
            new Order { OrderId = 302, CustomerId = 4, OrderDate = DateTime.Now.AddDays(-7) }
        };

        // LINQ to join customers and orders
        var customerOrders = customers.GroupJoin(
            orders,
            customer => customer.CustomerId,
            order => order.CustomerId,
            (customer, orderList) => new
            {
                CustomerName = customer.Name,
                OrderIds = orderList.Select(order => order.OrderId).ToList()
            });

        Console.WriteLine("Customer Orders:");

        foreach (var customerOrder in customerOrders)
        {
            if (customerOrder.OrderIds.Any())  // Check if the customer has any orders
            {
                Console.WriteLine($"{customerOrder.CustomerName}: {string.Join(", ", customerOrder.OrderIds)}");
            }
            else
            {
                Console.WriteLine($"{customerOrder.CustomerName}: No orders");
            }
        }
    }
}


