using System;

namespace BLL.Interface.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] PhotoData { get; set; }
        public string PhotoMimeType { get; set; }
        public DateTime CreationDate { get; set; }
        public int StudyGroupId { get; set; }
    }
}