using DAL.Interface.DTO;
using ORM;

namespace DAL.Mappers
{
    public static class DalUserMapper
    {
        public static DalUser ToDalUser(this User user)
        {
            if (user == null)
                return null;
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
        public static User ToUser(this DalUser user)
        {
            if (user == null)
                return null;
            return new User()
            {
                //Id = questionAnswer.Id,
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
