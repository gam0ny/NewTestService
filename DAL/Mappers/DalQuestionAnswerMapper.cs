using DAL.Interface.DTO;
using ORM;

namespace DAL.Mappers
{
    public static class DalQuestionAnswerMapper
    {
        public static DalQuestionAnswer ToDalQuestionAnswer(this QuestionAnswer questionAnswer)
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
        public static QuestionAnswer ToQuestionAnswer(this DalQuestionAnswer questionAnswer)
        {
            if (questionAnswer == null)
                return null;
            return new QuestionAnswer()
            {
                //Id = questionAnswer.Id,
                Content = questionAnswer.Content,
                Correct = questionAnswer.Correct,
                QuestionId = questionAnswer.QuestionId
            };
        }
    }
}
