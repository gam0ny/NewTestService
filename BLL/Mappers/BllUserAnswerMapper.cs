using BLL.Interface.Entities;
using DAL.Interface.DTO;

namespace BLL.Mappers
{
    public static class BllUserAnswerMapper
    {
        public static DalUserAnswer ToDalUserAnswer(this UserAnswerEntity userAnswer)
        {
            if (userAnswer == null)
                return null;
            return new DalUserAnswer()
            {
                Id = userAnswer.Id,
                ResultId = userAnswer.ResultId,
                QuestionId = userAnswer.QuestionId,
                QuestionAnswerId = userAnswer.QuestionAnswerId
            };
        }
        public static UserAnswerEntity ToBllUserAnswer(this DalUserAnswer userAnswer)
        {
            if (userAnswer == null)
                return null;
            return new UserAnswerEntity()
            {
                Id = userAnswer.Id,
                ResultId = userAnswer.ResultId,
                QuestionId = userAnswer.QuestionId,
                QuestionAnswerId = userAnswer.QuestionAnswerId
            };
        }
    }
}
