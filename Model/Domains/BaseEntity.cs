namespace Model.Domains
{
    public interface BaseEntity
    {
        int Id { get; set; }
        DateTime CreateDate { get; set; }
        DateTime UpdateDate { get; set; }
        bool  IsDeleted { get; set; }

    }
}
