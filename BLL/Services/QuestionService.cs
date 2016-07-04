using BLL.Interface.Entities;
using BLL.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface.Repository;
using BLL.Mappers;

namespace BLL.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IUnitOfWork uow;

        public QuestionService(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public QuestionEntity GetQuestionEntity(int id)
        {
            throw new NotImplementedException();
        }
        public QuestionEntity GetQuestionEntityById(int? id)
        {
            if (id == null)
                return null;
            return uow.QuestionRrepository.GetById((int)id).ToBllQuestion();
        }
        
    }
}
