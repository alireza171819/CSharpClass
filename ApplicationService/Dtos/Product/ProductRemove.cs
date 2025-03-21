namespace ApplicationService.Dtos.Product
{
    public class ProductRemove
    {
        public int Id { get; set; }
    }

    public enum RemoveResult
    {
        Success,
        Error,
        NotFound,
        NullReference
    }
}
