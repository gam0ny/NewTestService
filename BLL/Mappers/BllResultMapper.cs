using BLL.Interface.Entities;
using DAL.Interface.DTO;

namespace BLL.Mappers
{
    public static class DalResultMapper
    {
        public static DalResult ToDalResult(this ResultEntity result)
        {
            if (result == null)
                return null;
            return new DalResult()
            {
                Id = result.Id,
                Mark = result.Mark,
                TestId = result.TestId,
                UserId = result.UserId,
                Date = result.Date
            };
        }
        public static ResultEntity ToBllResult(this DalResult result)
        {
            if (result == null)
                return null;
            return new ResultEntity()
            {
                Id = result.Id,
                Mark = result.Mark,
                TestId = result.TestId,
                UserId = result.UserId,
                Date = result.Date
            };
        }
    }
}
