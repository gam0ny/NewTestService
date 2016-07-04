using BLL.Interface.Entities;
using System;
using System.Collections.Generic;

namespace BLL.Interface.Services
{
    public interface IQuestionAnswerService
    {
        IEnumerable<QuestionAnswerEntity> GetQuestionAnswerEntityByQuestionId(int testId);
        QuestionAnswerEntity GetQuestionAnswerEntityById(int id);
    }
}
