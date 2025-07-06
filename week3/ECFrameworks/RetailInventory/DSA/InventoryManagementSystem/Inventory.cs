using System;
using System.Collections.Generic;

public class Inventory
{
    private Dictionary<int, Product> _products = new Dictionary<int, Product>();

    public void AddProduct(Product product)
    {
        if (!_products.ContainsKey(product.ProductId))
        {
            _products[product.ProductId] = product;
            Console.WriteLine("Product added.");
        }
        else
        {
            Console.WriteLine("Product ID already exists.");
        }
    }

    public void UpdateProduct(int id, int quantity, decimal price)
    {
        if (_products.ContainsKey(id))
        {
            _products[id].Quantity = quantity;
            _products[id].Price = price;
            Console.WriteLine("Product updated.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void DeleteProduct(int id)
    {
        if (_products.Remove(id))
            Console.WriteLine("Product deleted.");
        else
            Console.WriteLine("Product not found.");
    }

    public void PrintAll()
    {
        Console.WriteLine("\nInventory:");
        foreach (var item in _products.Values)
            Console.WriteLine(item);
    }
}
