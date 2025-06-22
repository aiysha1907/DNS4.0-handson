public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }

    public Product(int id, string name, int qty, decimal price)
    {
        ProductId = id;
        ProductName = name;
        Quantity = qty;
        Price = price;
    }

    public override string ToString()
    {
        return $"ID: {ProductId}, Name: {ProductName}, Qty: {Quantity}, Price: ₹{Price}";
    }
}
