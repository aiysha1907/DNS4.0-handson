// See https://aka.ms/new-console-template for more information

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        inventory.AddProduct(new Product(1, "Laptop", 5, 75000));
        inventory.AddProduct(new Product(2, "Monitor", 10, 15000));

        inventory.PrintAll();

        inventory.UpdateProduct(1, 7, 74000);
        inventory.DeleteProduct(2);

        inventory.PrintAll();
    }
}
