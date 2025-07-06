// using Microsoft.EntityFrameworkCore;
// using RetailInventory.Models;


// Console.WriteLine(" Starting EF Core Demo...");
//lab6
using RetailInventory.Models;
using Microsoft.EntityFrameworkCore;

await MainAsync();

async Task MainAsync()
{
    Console.WriteLine("🔧 Starting EF Core Demo...");
    
    using var context = new AppDbContext();

    // Your async logic here 👇
}




using var context = new AppDbContext();

// Ensure database is created (Lab 3)
context.Database.EnsureCreated();

// // Lab 4: Seed data only if not already present
// if (!context.Categories.Any())
// {
//     var electronics = new Category { Name = "Electronics" };
//     var grocery = new Category { Name = "Grocery" };

//     context.Categories.AddRange(electronics, grocery);

//     context.Products.AddRange(
//         new Product { Name = "Smartphone", Price = 499.99m, Category = electronics },
//         new Product { Name = "Laptop", Price = 999.99m, Category = electronics },
//         new Product { Name = "Apples", Price = 2.99m, Category = grocery }
//     );

//     context.SaveChanges();
//     Console.WriteLine("Seed data inserted.");
// } 
// else
// {
//     Console.WriteLine("Data already exists. Skipping seeding...");
// }

// Print out products with category info
var products = context.Products.Include(p => p.Category).ToList();

Console.WriteLine("Product List:");
foreach (var p in products)
{
    Console.WriteLine($"- {p.Name} ({p.Category.Name}) - ₹{p.Price}");
}
Console.WriteLine("\n All Products with Categories:");
var allProducts = context.Products.Include(p => p.Category).ToList();

foreach (var p in allProducts)
{
    Console.WriteLine($"- {p.Name} ({p.Category.Name}) - ₹{p.Price}");
}
Console.WriteLine("\n Products priced above ₹500:");
var expensive = context.Products
    .Where(p => p.Price > 500)
    .Include(p => p.Category)
    .ToList();

foreach (var p in expensive)
{
    Console.WriteLine($"- {p.Name} - ₹{p.Price}");
}
Console.WriteLine("\n Products sorted alphabetically:");
var sorted = context.Products
    .OrderBy(p => p.Name)
    .Include(p => p.Category)
    .ToList();

foreach (var p in sorted)
{
    Console.WriteLine($"- {p.Name} ({p.Category.Name})");
}
Console.WriteLine("\n Products in 'Electronics' category:");
var electronics = context.Products
    .Include(p => p.Category)
    .Where(p => p.Category.Name == "Electronics")
    .ToList();

foreach (var p in electronics)
{
    Console.WriteLine($"- {p.Name} - ₹{p.Price}");
}

//lab5
Console.WriteLine("\n Updating price of 'Smartphone' to ₹549.99...");

var smartphone = context.Products.FirstOrDefault(p => p.Name == "Smartphone");
if (smartphone != null)
{
    smartphone.Price = 549.99m;
    context.SaveChanges();
    Console.WriteLine(" Smartphone price updated.");
}
else
{
    Console.WriteLine("Product not found.");
}

Console.WriteLine("\n Deleting product: 'Apples'...");

var apples = context.Products.FirstOrDefault(p => p.Name == "Apples");
if (apples != null)
{
    context.Products.Remove(apples);
    context.SaveChanges();
    Console.WriteLine(" Apples deleted.");
}
else
{
    Console.WriteLine("Product 'Apples' not found.");
}


Console.WriteLine("\n Remaining products in database:");
var remaining = context.Products.Include(p => p.Category).ToList();

foreach (var p in remaining)
{
    Console.WriteLine($"- {p.Name} ({p.Category.Name}) - ₹{p.Price}");
}

//lab6
Console.WriteLine("\n📦 All Products (Async):");

var allProducts = await context.Products
    .Include(p => p.Category)
    .ToListAsync();

foreach (var p in allProducts)
{
    Console.WriteLine($"- {p.Name} ({p.Category.Name}) - ₹{p.Price}");
}
Console.WriteLine("\n📝 Updating 'Laptop' price to ₹1049.99...");

var laptop = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");
if (laptop != null)
{
    laptop.Price = 1049.99m;
    await context.SaveChangesAsync();
    Console.WriteLine("✅ Laptop price updated.");
}
Console.WriteLine("\n🗑️ Deleting 'Smartphone'...");

var smartphone = await context.Products.FirstOrDefaultAsync(p => p.Name == "Smartphone");
if (smartphone != null)
{
    context.Products.Remove(smartphone);
    await context.SaveChangesAsync();
    Console.WriteLine("✅ Smartphone deleted.");
}
Console.WriteLine("\n📦 Remaining products:");

var finalProducts = await context.Products.Include(p => p.Category).ToListAsync();

foreach (var p in finalProducts)
{
    Console.WriteLine($"- {p.Name} ({p.Category.Name}) - ₹{p.Price}");
}
