// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        SearchEngine engine = new SearchEngine();

        engine.AddProduct(new Product(1, "iPhone 15"));
        engine.AddProduct(new Product(2, "Samsung Galaxy S23"));
        engine.AddProduct(new Product(3, "OnePlus Nord"));
        engine.AddProduct(new Product(4, "MacBook Air"));
        engine.AddProduct(new Product(5, "iPad Pro"));

        Console.WriteLine("Search (contains 'Pro'):");
        List<Product> results = engine.SearchByContains("Pro");
        foreach (var p in results)
            Console.WriteLine(p);

        Console.WriteLine("\nSearch Exact: 'iPhone 15'");
        var exact = engine.SearchExact("iPhone 15");
       if (exact != null)
    Console.WriteLine(exact);
else
    Console.WriteLine("No match found.");

    }
}
