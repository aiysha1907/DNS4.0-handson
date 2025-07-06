// using Microsoft.EntityFrameworkCore;
// using RetailInventory.Models;

// public class AppDbContext : DbContext
// {
//     public DbSet<Product> Products { get; set; }
//     public DbSet<Category> Categories { get; set; }

//     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//     {
//         optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=RetailDB;Trusted_Connection=True;");
//     }
// }


using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=RetailDB;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed categories
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Grocery" }
        );

        // Seed products
        modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Name = "Smartphone", Price = 499.99m, CategoryId = 1 },
            new Product { Id = 2, Name = "Laptop", Price = 999.99m, CategoryId = 1 },
            new Product { Id = 3, Name = "Apples", Price = 2.99m, CategoryId = 2 }
        );
    }
}
