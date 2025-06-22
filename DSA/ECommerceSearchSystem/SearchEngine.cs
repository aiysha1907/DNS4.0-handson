using System;
using System.Collections.Generic;
using System.Linq;

public class SearchEngine
{
    private List<Product> _products = new List<Product>();
    private Dictionary<string, Product> _index = new Dictionary<string, Product>(StringComparer.OrdinalIgnoreCase);

    public void AddProduct(Product p)
    {
        _products.Add(p);
        _index[p.ProductName] = p; // For O(1) lookup
    }

    // Linear search (O(n))
    public List<Product> SearchByContains(string query)
    {
        return _products
            .Where(p => p.ProductName.IndexOf(query, StringComparison.OrdinalIgnoreCase) >= 0)
            .ToList();
    }

    // Exact match (O(1))
    public Product SearchExact(string name)
    {
        return _index.ContainsKey(name) ? _index[name] : null;
    }
}
