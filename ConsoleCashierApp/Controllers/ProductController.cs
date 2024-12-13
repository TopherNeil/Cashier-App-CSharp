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
        using (var reader = new StreamReader("C:\\Users\\Chon\\RiderProjects\\Cashier-App-CSharp\\ConsoleCashierApp\\CSVFiles\\Products.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<Product>().ToList();
            if (records.Count != 0)
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