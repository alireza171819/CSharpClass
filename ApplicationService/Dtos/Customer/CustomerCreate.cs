namespace ApplicationService.Dtos.Customer
{
    public class CustomerCreate
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        
    }

    public enum CreateResult
    {
        Success,
        Error,
        NullReference
    }
}
