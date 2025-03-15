namespace ApplicationService.Dtos;

public class Customer
{
    public bool IsDeleted { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOdBirth { get; set; }
    public string FullName { get => FirstName + LastName; }
}