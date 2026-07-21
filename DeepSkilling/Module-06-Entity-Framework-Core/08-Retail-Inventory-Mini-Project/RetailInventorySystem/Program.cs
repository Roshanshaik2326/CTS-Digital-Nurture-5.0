using RetailInventorySystem.Data;
using RetailInventorySystem.Models;

using var context = new AppDbContext();

context.Database.EnsureCreated();

// Add sample products only once
if (!context.Products.Any())
{
    context.Products.AddRange(
        new Product
        {
            ProductName = "Laptop",
            Category = "Electronics",
            Price = 65000,
            Quantity = 10
        },
        new Product
        {
            ProductName = "Keyboard",
            Category = "Accessories",
            Price = 1200,
            Quantity = 50
        },
        new Product
        {
            ProductName = "Mouse",
            Category = "Accessories",
            Price = 700,
            Quantity = 40
        }
    );

    context.SaveChanges();
}

// Display all products
Console.WriteLine("===== PRODUCT LIST =====\n");

foreach (var product in context.Products)
{
    Console.WriteLine(
        $"{product.ProductId} | {product.ProductName} | {product.Category} | ₹{product.Price} | Qty: {product.Quantity}");
}

// Update Product Price
var laptop = context.Products.FirstOrDefault(p => p.ProductName == "Laptop");

if (laptop != null)
{
    laptop.Price = 68000;
    context.SaveChanges();
    Console.WriteLine("\nLaptop price updated.");
}

// Search Products
Console.WriteLine("\nProducts in Accessories:");

var accessories = context.Products
    .Where(p => p.Category == "Accessories")
    .ToList();

foreach (var item in accessories)
{
    Console.WriteLine(item.ProductName);
}

// Delete Product
var mouse = context.Products.FirstOrDefault(p => p.ProductName == "Mouse");

if (mouse != null)
{
    context.Products.Remove(mouse);
    context.SaveChanges();

    Console.WriteLine("\nMouse removed from inventory.");
}