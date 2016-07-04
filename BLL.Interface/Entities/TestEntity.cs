﻿namespace BLL.Interface.Entities
{
    public class TestEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public long TimeToDo { get; set; }
        public string Name { get; set; }
        public bool Publish { get; set; }
        public bool IsDelete { get; set; }
        public int MarkToSuccess { get; set; }
    }
}
