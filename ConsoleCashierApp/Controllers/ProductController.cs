using ConsoleCashierApp.Models;
using CsvHelper;

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
        Console.WriteLine("How many entries would you like to enter?");
        var numberOfEntries = Int32.Parse(Console.ReadLine());
        
        for (var i = 0; i < numberOfEntries; i++)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Entry number: {i + 1}");
            EntriesInput(i);
        }
        
        // Write into the CSV file
        using (var writer = new StreamWriter("C:\\Users\\Chon\\RiderProjects\\Cashier-App-CSharp\\ConsoleCashierApp\\CSVFiles\\Products.csv"))
        using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        {
                csv.WriteRecords(newRecords);
        }
    }
    
    private static List<Product> EntriesInput(int Id)
    {
        Console.Write("Enter Name: ");
        var name = Console.ReadLine();
        Console.Write("Enter Price: ");
        var price = Double.Parse(Console.ReadLine());
        Console.Write("Enter number of stock: ");
        var numberOfStock = Int32.Parse(Console.ReadLine());
        
        newRecords.Add(new Product(){Id = Id, Name = name, Price = price, NumberOfStock = numberOfStock});
        return newRecords;
    }
    
}