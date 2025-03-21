namespace ApplicationService.Dtos.Product
{
    public class ProductUpdate
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Sku { get; set; }
        public decimal UnitPrice { get; set; }
    }

    public enum UpdateResult
    {
        Success,
        Error,
        NotFound,
        NullReference
    }
}
