namespace ApplicationService.Dtos.Product
{
    public class ProductUpdate
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Sku { get; set; }
        public decimal UnitPrice { get; set; }
        public bool  IsDelete { get; set; }
    }

    public enum UpdateReturn
    {
        Success,
        Error,
        NotFound,
        NullReference
    }
}
