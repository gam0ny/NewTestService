using BLL.Interface.Entities;
using BLL.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Interface.Repository;
using BLL.Mappers;

namespace BLL.Services
{
    public class QuestionAnswerService : IQuestionAnswerService
    {
        private readonly IUnitOfWork uow;

        public QuestionAnswerService(IUnitOfWork uow)
        {
            this.uow = uow;
        }

        public IEnumerable<QuestionAnswerEntity> GetQuestionAnswerEntityByQuestionId(int questionId)
        {
            return uow.QuestionAnswerRepository.GetDalQuestionAnswerByQuestionId(questionId).Select(q => q.ToBllQuestionAnswer());
        }
        public QuestionAnswerEntity GetQuestionAnswerEntityById(int id)
        {
            return uow.QuestionAnswerRepository.GetById(id).ToBllQuestionAnswer();
        }
    }
}
