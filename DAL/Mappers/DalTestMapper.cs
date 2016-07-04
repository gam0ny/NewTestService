using DAL.Interface.DTO;
using ORM;

namespace DAL.Mappers
{
    public static class DalTestMapper
    {
        public static DalTest ToDalTest(this Test test)
        {
            if (test == null)
                return null;
            return new DalTest()
            {
                Id = test.Id,
                Name=test.Name,
                UserId = test.UserId,
                TimeToDo=test.TimeToDo,
                Publish = test.Publish,
                IsDelete = test.IsDelete,
                MarkToSuccess = test.MarkToSuccess
            };
        }
        public static Test ToTest(this DalTest test)
        {
            if (test == null)
                return null;
            return new Test()
            {
                //Id = test.Id,
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
