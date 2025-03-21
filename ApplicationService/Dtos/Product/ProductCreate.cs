namespace ApplicationService.Dtos.Product
{
    public class ProductCreate
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Sku { get; set; }
        public decimal UnitPrice { get; set; }
    }

    public enum CreateReturn
    {
        Success,
        Error,
        NullReference
    }
}
