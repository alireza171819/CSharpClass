namespace ApplicationService.Dtos.Customer
{
    public class CustomerInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string FullName { get => FirstName + LastName; }
    }
}
