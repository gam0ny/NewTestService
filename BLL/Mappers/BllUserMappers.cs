using BLL.Interface.Entities;
using DAL.Interface.DTO;

namespace BLL.Mappers
{
    public static class BllUserMappers
    {
        public static DalUser ToDalUser(this UserEntity user)
        {
            return new DalUser()
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Password = user.Password,
                PhotoData = user.PhotoData,
                PhotoMimeType = user.PhotoMimeType,
                CreationDate = user.CreationDate,
                StudyGroupId = user.StudyGroupId
            };
        }

        public static UserEntity ToBllUser(this DalUser user)
        {
            return new UserEntity()
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Password = user.Password,
                PhotoData = user.PhotoData,
                PhotoMimeType = user.PhotoMimeType,
                CreationDate = user.CreationDate,
                StudyGroupId = user.StudyGroupId
            };
        }
    }
}
