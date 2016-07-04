namespace ORM
{
    using System.Data.Entity;

    public partial class EntityModel : DbContext
    {
        public EntityModel()
            : base("name=EntityModel")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<QuestionAnswer> QuestionAnswers { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<UserAnswer> UserAnswers { get; set; }
        public virtual DbSet<QuestionToTest> QuestionToTests { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<StudyGroup> StudyGroups { get; set; }
        public virtual DbSet<UsersToRole> UsersToRoles { get; set; }

    }
}
