﻿namespace Model.Domains
{
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
        public string FullName { get => FirstName + LastName; }
    }
}
