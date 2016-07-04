using BLL.Interface.Entities;
using DAL.Interface.DTO;

namespace BLL.Mappers
{
    public static class BLLQuestionToTestMapper
    {
        public static DalQuestionToTest ToDalQuestionToTest(this QuestionToTestEntity questionToTest)
        {
            if (questionToTest == null)
                return null;
            return new DalQuestionToTest()
            {
                Id = questionToTest.Id,
                QuestionId = questionToTest.QuestionId,
                TestId = questionToTest.TestId
            };
        }
        public static QuestionToTestEntity ToBllQuestionToTest(this DalQuestionToTest questionToTest)
        {
            if (questionToTest == null)
                return null;
            return new QuestionToTestEntity()
            {

                Id = questionToTest.Id,
                QuestionId = questionToTest.QuestionId,
                TestId = questionToTest.TestId
            };
        }
    }
}
