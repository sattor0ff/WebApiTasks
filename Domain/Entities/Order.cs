namespace Domain.Entities;

public class Order
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int CustomerId { get; set; }
    public DateTime Createdat { get; set; }
    public int ProductCount { get; set; }
    public decimal Price { get; set; }
}