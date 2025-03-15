namespace Model.Domains
{
    public class Product : EntityBase
    {
        public Product()
        {
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            IsDeleted = false;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public int Sku { get; set; }
        public decimal UnitPrice { get; set; }
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
