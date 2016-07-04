using DAL.Interface.DTO;
using ORM;

namespace DAL.Mappers
{
    public static class DalRoleMapper
    {
        public static DalRole ToDalRole(this Role role)
        {
            if (role == null)
                return null;
            return new DalRole()
            {
                Id = role.Id,
                Name = role.Name,
                Description = role.Description
            };
        }
        public static Role ToRole(this DalRole role)
        {
            if (role == null)
                return null;
            return new Role()
            {
                //Id = studyGroup.Id,
                Name = role.Name,
                Description = role.Description
            };
        }
    }
}
