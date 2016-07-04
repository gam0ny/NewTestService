namespace ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
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
        public virtual StudyGroup StudyGroup { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
        public virtual ICollection<Result> Results { get; set; }
        public virtual ICollection<UsersToRole> UsersToRoles { get; set; }

        public User()
        {
            Questions = new HashSet<Question>();
            Tests = new HashSet<Test>();
            Results = new HashSet<Result>();
            UsersToRoles = new HashSet<UsersToRole>();
        }

    }
}
