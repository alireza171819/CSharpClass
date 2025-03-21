namespace ApplicationService.Dtos.Customer
{
    public class CustomerUpdate
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    public enum UpdateResult
    {
        Success,
        Error,
        NotFound,
        NullReference
    }
}
