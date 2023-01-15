namespace Domain.Entities;

public class Product
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public string Company { get; set; }
    public int ProductCount { get; set; }
    public decimal Price { get; set; }
}