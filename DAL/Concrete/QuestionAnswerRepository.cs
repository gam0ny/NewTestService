using DAL.Interfacies.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Interface.DTO;
using System.Data.Entity;
using ORM;
using DAL.Mappers;
using System.Linq.Expressions;

namespace DAL.Concrete
{
    public class QuestionAnswerRepository : IQuestionAnswerRepository
    {
        private DbContext context;
        public QuestionAnswerRepository(DbContext context)
        {
            this.context = context;
        }
        public void Create(DalQuestionAnswer e)
        {
            if (e == null) return;
            var tmp = e.ToQuestionAnswer();
            context.Set<QuestionAnswer>().Add(tmp);
        }

        public void Delete(int id)
        {
            var tmp = context.Set<QuestionAnswer>().SingleOrDefault(t => t.Id== id);
            if (tmp != default(QuestionAnswer))
                context.Set<QuestionAnswer>().Remove(tmp);
        }

        public IEnumerable<DalQuestionAnswer> GetAll()
        {
            return context.Set<QuestionAnswer>().ToList().Select(t => t.ToDalQuestionAnswer());
        }

        public DalQuestionAnswer GetById(int key)
        {
            return context.Set<QuestionAnswer>().FirstOrDefault(t => t.Id == key)?.ToDalQuestionAnswer();
        }

        public DalQuestionAnswer GetByPredicate(Expression<Func<DalQuestionAnswer, bool>> f)
        {
            return context.Set<QuestionAnswer>().Select(t => t.ToDalQuestionAnswer()).FirstOrDefault(f);
        }

        public IEnumerable<DalQuestionAnswer> GetDalQuestionAnswerByQuestionId(int questionId)
        {
            return context.Set<QuestionAnswer>().Where(t => t.QuestionId == questionId).ToList().Select(t => t.ToDalQuestionAnswer());
        }

        public void Update(DalQuestionAnswer entity)
        {
            var tmp = context.Set<QuestionAnswer>().SingleOrDefault(t => t.Id == entity.Id);

            if (tmp != null)
                return;
            tmp = entity.ToQuestionAnswer();
            context.Entry(tmp).State = EntityState.Modified;
        }
    }
}
