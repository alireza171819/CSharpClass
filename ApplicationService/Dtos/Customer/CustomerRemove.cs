﻿namespace ApplicationService.Dtos.Customer
{
    public class CustomerRemove
    {
        public int Id { get; set; }
    }

    public enum RemoveResult
    {
        Success,
        Error,
        NotFound,
        NullReference
    }
}
