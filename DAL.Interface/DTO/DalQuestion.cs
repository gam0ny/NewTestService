using System;

namespace DAL.Interface.DTO
{
    public class DalQuestion : IEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Cost { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public bool IsDelete { get; set; }
    }
}
