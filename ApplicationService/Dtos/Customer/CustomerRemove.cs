namespace ApplicationService.Dtos.Customer
{
    public class CustomerRemove
    {
        public int Id { get; set; }
    }

    public enum RemoveReturn
    {
        Success,
        Error,
        NotFound
    }
}
