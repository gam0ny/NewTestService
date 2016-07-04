using BLL.Interface.Entities;
using DAL.Interface.DTO;

namespace BLL.Mappers
{
    public static class BllTestMapper
    {
        public static DalTest ToDalTest(this TestEntity test)
        {
            if (test == null)
                return null;
            return new DalTest()
            {
                Id = test.Id,
                Name = test.Name,
                UserId = test.UserId,
                TimeToDo = test.TimeToDo,
                Publish = test.Publish,
                IsDelete = test.IsDelete,
                MarkToSuccess = test.MarkToSuccess
            };
        }
        public static TestEntity ToBllTest(this DalTest test)
        {
            if (test == null)
                return null;
            return new TestEntity()
            {
                Id = test.Id,
                Name = test.Name,
                UserId = test.UserId,
                TimeToDo = test.TimeToDo,
                Publish = test.Publish,
                IsDelete = test.IsDelete,
                MarkToSuccess = test.MarkToSuccess
            };
        }

    }
}
