namespace Model.Domains
{
    public interface Person : BaseEntity
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        enum Gender 
        {
            Male = 0,
            Female = 1,
        }
        string FullName { get; }
        DateTime DateOdBirth { get; set; }
    }
}
