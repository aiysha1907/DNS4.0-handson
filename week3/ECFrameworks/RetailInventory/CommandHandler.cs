using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

public static class CommandHandler
{
    public static async Task ExecuteAsync(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("⚠️ Please provide a command: add | list | update | delete");
            return;
        }

        using var context = new AppDbContext();
        string cmd = args[0].ToLower();

        switch (cmd)
        {
            case "add":
                await AddProductAsync(context, args);
                break;
            case "list":
                await ListProductsAsync(context);
                break;
            case "update":
                await UpdateProductAsync(context, args);
                break;
            case "delete":
                await DeleteProductAsync(context, args);
                break;
            default:
                Console.WriteLine("❌ Invalid command. Use: add | list | update | delete");
                break;
        }
    }

    private static async Task AddProductAsync(AppDbContext context, string[] args)
    {
        if (args.Length < 4)
        {
            Console.WriteLine("Usage: add <name> <price> <categoryId>");
            return;
        }

        string name = args[1];
        decimal price = decimal.Parse(args[2]);
        int categoryId = int.Parse(args[3]);

        var product = new Product { Name = name, Price = price, CategoryId = categoryId };
        context.Products.Add(product);
        await context.SaveChangesAsync();

        Console.WriteLine($"✅ Added: {name}");
    }

    private static async Task ListProductsAsync(AppDbContext context)
    {
        var products = await context.Products.Include(p => p.Category).ToListAsync();
        Console.WriteLine("📦 Product List:");
        foreach (var p in products)
        {
            Console.WriteLine($"- {p.Id}: {p.Name} ({p.Category.Name}) - ₹{p.Price}");
        }
    }

    private static async Task UpdateProductAsync(AppDbContext context, string[] args)
    {
        if (args.Length < 3)
        {
            Console.WriteLine("Usage: update <id> <newPrice>");
            return;
        }

        int id = int.Parse(args[1]);
        decimal newPrice = decimal.Parse(args[2]);

        var product = await context.Products.FindAsync(id);
        if (product is null)
        {
            Console.WriteLine("❌ Product not found.");
            return;
        }

        product.Price = newPrice;
        await context.SaveChangesAsync();
        Console.WriteLine($"✅ Updated: {product.Name} - ₹{newPrice}");
    }

    private static async Task DeleteProductAsync(AppDbContext context, string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Usage: delete <id>");
            return;
        }

        int id = int.Parse(args[1]);
        var product = await context.Products.FindAsync(id);
        if (product is null)
        {
            Console.WriteLine("❌ Product not found.");
            return;
        }

        context.Products.Remove(product);
        await context.SaveChangesAsync();
        Console.WriteLine($"✅ Deleted: {product.Name}");
    }
}
