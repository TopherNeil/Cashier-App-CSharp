using ConsoleCashierApp.Models;

namespace ConsoleCashierApp.Controllers;

public class ProductController
{
    private static List<Product> SampleProductData = new List<Product>()
    {
        new Product() { Id = 1, Name = "Choco Mucho", NumberOfStock = 0, Price = 200.00 }
    };

    public static void Index()
    {
        Console.WriteLine("To print the result for the sample product data: ");
        var query = from product in SampleProductData
            where product.Name == "Choco Mucho"
            select new
            {
                product.Name,
                product.NumberOfStock,
                product.Price
            };
        foreach (var product in query)
        {
            Console.WriteLine($"Product Name: {product.Name}\nNumber of stock: {product.NumberOfStock}\nPrice: {product.Price}");
        }
    }
    
    
    public static void Store()
    {
        
    }
}