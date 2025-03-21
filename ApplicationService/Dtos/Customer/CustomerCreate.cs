namespace ApplicationService.Dtos.Customer
{
    public class CustomerCreate
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOdBirth { get; set; }
        
    }

    public enum CreateReturn
    {
        Success,
        Error,
        NullReference
    }
}
