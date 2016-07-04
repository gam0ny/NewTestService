using DAL.Interface.DTO;
using ORM;

namespace DAL.Mappers
{
    public static class DalUsersToRoleMapper
    {
        public static DalUsersToRole ToDalUsersToRole(this UsersToRole usersToRole)
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
        public static UsersToRole ToUsersToRole(this DalUsersToRole usersToRole)
        {
            if (usersToRole == null)
                return null;
            return new UsersToRole()
            {

                //Id = questionAnswer.Id,
                UserId = usersToRole.UserId,
                RoleId = usersToRole.RoleId
            };
        }
    }
}
