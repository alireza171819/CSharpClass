namespace Model.Domains
{
    public interface BaseEntity
    {
        int Id { get; set; }
        DateTime CreateDate { get; set; }
        DateTime UpdateDate { get; set; }
        bool  IsDeleted { get; set; }

    }

    public interface Person : BaseEntity
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        enum Gender 
        {
            Male = 0,
            Female = 1,
        }
        //string FullName { get; set; }
        DateTime DateOdBirth { get; set; }
    }


    public class Product : BaseEntity
    {
        public Product()
        {
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            IsDeleted = false;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public int Sku { get; set; }
        public decimal UnitPrice { get; set; }
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class Admin : Person
    {
        public Admin() 
        {
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            IsDeleted = false;
        }  
        public int Id { get ; set ; }
        public DateTime CreateDate { get ; set ; }
        public DateTime UpdateDate { get ; set ; }
        public bool IsDeleted { get ; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public DateTime DateOdBirth { get ; set ; }
        //public string FullName { get => FirstName + LastName; set; }
    }

    public class Customer : Person
    {
        public Customer()
        {
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
            IsDeleted = false;
        }
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDeleted { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOdBirth { get; set; }
    }
}
