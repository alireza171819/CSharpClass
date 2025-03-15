namespace ApplicationService.Dtos;

public class Product 
{
    public string Title { get; set; }
    public string Description { get; set; }
    public int Sku { get; set; }
    public decimal UnitPrice { get; set; }
    public bool IsDeleted { get; set; }
}