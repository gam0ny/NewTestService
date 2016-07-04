using DAL.Interface.DTO;
using ORM;

namespace DAL.Mappers
{
    public static class DalQuestionMapper
    {
        public static DalQuestion ToDalQuestion(this Question question)
        {
            if (question == null)
                return null;
            return new DalQuestion()
            {
                Id = question.Id,
                Content = question.Content,
                Cost = question.Cost,
                UserId = question.UserId,
                Date = question.Date,
                IsDelete = question.IsDelete
            };
        }
        public static Question ToQuestion(this DalQuestion question)
        {
            if (question == null)
                return null;
            return new Question()
            {
                //Id = question.Id,
                Content = question.Content,
                Cost = question.Cost,
                UserId = question.UserId,
                Date = question.Date,
                IsDelete = question.IsDelete
            };
        }
    }
}
