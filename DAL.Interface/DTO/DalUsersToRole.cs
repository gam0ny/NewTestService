namespace DAL.Interface.DTO
{
    public class DalUsersToRole : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
