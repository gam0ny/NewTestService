using System;

namespace BLL.Interface.Entities
{
    public class UsersToRoleEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }
}
