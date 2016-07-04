using DAL.Interface.DTO;
using ORM;

namespace DAL.Mappers
{
    public static class DalResultMapper
    {
        public static DalResult ToDalResult(this Result result)
        {
            if (result == null)
                return null;
            return new DalResult()
            {
                Id = result.Id,
                Mark = result.Mark,
                TestId = result.TestId,
                UserId = result.UserId,
                Date=result.Date
            };
        }
        public static Result ToResult(this DalResult result)
        {
            if (result == null)
                return null;
            return new Result()
            {
                //Id = result.Id,
                Mark = result.Mark,
                TestId = result.TestId,
                UserId = result.UserId,
                Date = result.Date
            };
        }
    }
}
