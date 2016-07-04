using DAL.Interface.DTO;
using ORM;

namespace DAL.Mappers
{
    public static class DalStudyGroupMapper
    {
        public static DalStudyGroup ToDalStudyGroup(this StudyGroup studyGroup)
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
        public static StudyGroup ToStudyGroup(this DalStudyGroup studyGroup)
        {
            if (studyGroup == null)
                return null;
            return new StudyGroup()
            {
                //Id = studyGroup.Id,
                Name = studyGroup.Name,
                Description = studyGroup.Description
            };
        }
    }
}
