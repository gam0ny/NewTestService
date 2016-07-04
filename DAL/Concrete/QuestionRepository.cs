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
    public class QuestionRepository : IQuestionRepository
    {
        private DbContext context;
        public QuestionRepository(DbContext context)
        {
            this.context = context;
        }
        public void Create(DalQuestion e)
        {
            if (e == null) return;
            var tmp = e.ToQuestion();
            context.Set<Question>().Add(tmp);
        }

        public void Delete(int id)
        {
            var tmp = context.Set<Question>().SingleOrDefault(t => t.Id == id);
            if (tmp != default(Question))
                context.Set<Question>().Remove(tmp);
        }

        public IEnumerable<DalQuestion> GetAll()
        {
            return context.Set<Question>().ToList().Select(t => t.ToDalQuestion());
        }

        public DalQuestion GetById(int key)
        {
            
            return context.Set<Question>().FirstOrDefault(t => t.Id == key)?.ToDalQuestion();
        }

        public DalQuestion GetByPredicate(Expression<Func<DalQuestion, bool>> f)
        {
            return context.Set<Question>().Select(t => t.ToDalQuestion()).FirstOrDefault(f);
        }

        public void Update(DalQuestion entity)
        {
            var tmp = context.Set<Question>().SingleOrDefault(t => t.Id == entity.Id);

            if (tmp != null)
                return;
            tmp = entity.ToQuestion();
            context.Entry(tmp).State = EntityState.Modified;
        }
    }
}
