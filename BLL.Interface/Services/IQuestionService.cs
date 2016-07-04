using BLL.Interface.Entities;
using System;
using System.Collections.Generic;

namespace BLL.Interface.Services
{
    public interface IQuestionService
    {
        QuestionEntity GetQuestionEntity(int id);
        QuestionEntity GetQuestionEntityById(int? id);
    }
}
