namespace ConsoleCashierApp.Models;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsSeniorCitizen { get; set; }
    public bool IsMember { get; set; }
    public double TotalPurchased { get; set; }
    
}