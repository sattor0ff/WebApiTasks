namespace Domain.Dtos;

public class Task2Dto
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int CustomerId { get; set; }
    public DateTime Createdat { get; set; }
    public int ProductCount { get; set; }
    public decimal Price { get; set; }
    public string ProductName { get; set; }
    public string Company { get; set; }
}