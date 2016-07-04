using BLL.Interface.Entities;
using DAL.Interface.DTO;

namespace BLL.Mappers
{
    public static class DalQuestionAnswerMapper
    {
        public static DalQuestionAnswer ToDalQuestionAnswer(this QuestionAnswerEntity questionAnswer)
        {
            if (questionAnswer == null)
                return null;
            return new DalQuestionAnswer()
            {
                Id = questionAnswer.Id,
                Content = questionAnswer.Content,
                Correct = questionAnswer.Correct,
                QuestionId = questionAnswer.QuestionId
            };
        }
        public static QuestionAnswerEntity ToBllQuestionAnswer(this DalQuestionAnswer questionAnswer)
        {
            if (questionAnswer == null)
                return null;
            return new QuestionAnswerEntity()
            {
                Id = questionAnswer.Id,
                Content = questionAnswer.Content,
                Correct = questionAnswer.Correct,
                QuestionId = questionAnswer.QuestionId
            };
        }
    }
}
