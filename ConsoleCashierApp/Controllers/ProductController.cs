using ConsoleCashierApp.Models;

namespace ConsoleCashierApp.Controllers;

public class ProductController
{
    private static List<Product> newRecords = new List<Product>(){};
    public static void Index()
    {
        using (var reader = new StreamReader("C:\\Users\\Chon\\RiderProjects\\Cashier-App-CSharp\\ConsoleCashierApp\\CSVFiles\\Products.csv"))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<Product>().ToList();
            if (records.Count != 0)
            {
                foreach (var product in records.Select((value, i) => (value, i)))
                {
                    var value = product.value;
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine($"Product Id: {product.i}");
                    Console.WriteLine($"Name: {value.Name}");
                    Console.WriteLine($"Price: {value.Price}");
                    Console.WriteLine($"Number of stock: {value.NumberOfStock}");
                    Console.WriteLine("-----------------------------");
                }
            }
            else
            {
                Console.WriteLine("No records found.");
            }
        }
    }
    
    
    public static void Store()
    {
        
    }
}