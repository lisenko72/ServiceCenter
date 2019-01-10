using System;
using System.Collections.Generic;

namespace Service.Logic
{
    public class Order
    {
        public int Id { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateEnd { get; set; }
        public Status Status { get; set; }

        public Order(
            int id, 
            string shortDescription, 
            Status status,  
            string description = "",
            DateTime dateCreate = default(DateTime),
            DateTime dateEnd = default(DateTime))
        {
            Id = id;
            ShortDescription = shortDescription;
            Description = description;
            DateCreate = dateCreate == DateTime.MinValue ? DateTime.Now : dateCreate;
            DateEnd = dateEnd;
            Status = status;
        }
    }
}