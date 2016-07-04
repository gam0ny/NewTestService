using BLL.Interface.Entities;
using DAL.Interface.DTO;

namespace BLL.Mappers
{
    public static class BllStudyGroupMapper
    {
        public static DalStudyGroup ToDalStudyGroup(this StudyGroupEntity studyGroup)
        {
            if (studyGroup == null)
                return null;
            return new DalStudyGroup()
            {
                Id = studyGroup.Id,
                Name = studyGroup.Name,
                Description = studyGroup.Description
            };
        }
        public static StudyGroupEntity ToStudyGroup(this DalStudyGroup studyGroup)
        {
            if (studyGroup == null)
                return null;
            return new StudyGroupEntity()
            {
                Id = studyGroup.Id,
                Name = studyGroup.Name,
                Description = studyGroup.Description
            };
        }
    }
}
