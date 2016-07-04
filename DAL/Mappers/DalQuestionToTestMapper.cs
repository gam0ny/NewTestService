using DAL.Interface.DTO;
using ORM;

namespace DAL.Mappers
{
    public static class DalQuestionToTestMapper
    {
        public static DalQuestionToTest ToDalQuestionToTest(this QuestionToTest questionToTest)
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
        public static QuestionToTest ToQuestionToTest(this DalQuestionToTest questionToTest)
        {
            if (questionToTest == null)
                return null;
            return new QuestionToTest()
            {

                //Id = questionAnswer.Id,
                QuestionId = questionToTest.QuestionId,
                TestId = questionToTest.TestId
            };
        }
    }
}
