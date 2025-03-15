namespace Model.Domains
{
    public interface Person : EntityBase
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        enum Gender 
        {
            Male = 0,
            Female = 1,
        }
        DateTime DateOdBirth { get; set; }
    }
}
