using BLL.Interface.Entities;
using DAL.Interface.DTO;

namespace BLL.Mappers
{
    public static class BllUsersToRoleMapper
    {
        public static DalUsersToRole ToDalUsersToRole(this UsersToRoleEntity usersToRole)
        {
            if (usersToRole == null)
                return null;
            return new DalUsersToRole()
            {
                Id = usersToRole.Id,
                UserId = usersToRole.UserId,
                RoleId = usersToRole.RoleId
            };
        }
        public static UsersToRoleEntity ToBllUsersToRole(this DalUsersToRole usersToRole)
        {
            if (usersToRole == null)
                return null;
            return new UsersToRoleEntity()
            {

                Id = usersToRole.Id,
                UserId = usersToRole.UserId,
                RoleId = usersToRole.RoleId
            };
        }
    }
}
