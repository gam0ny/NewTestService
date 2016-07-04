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
    public class UserAnswerRepository : IUserAnswerRepository
    {
        private DbContext context;
        public UserAnswerRepository(DbContext context)
        {
            this.context = context;
        }
        public void Create(DalUserAnswer e)
        {
            if (e == null) return;
            var tmp = e.ToUserAnswer();
            context.Set<UserAnswer>().Add(tmp);
        }

        public void Delete(int id)
        {
            var tmp = context.Set<UserAnswer>().SingleOrDefault(t => t.Id == id);
            if (tmp != default(UserAnswer))
                context.Set<UserAnswer>().Remove(tmp);
        }

        public IEnumerable<DalUserAnswer> GetAll()
        {
            return context.Set<UserAnswer>().ToList().Select(t => t.ToDalUserAnswer());
        }

        public DalUserAnswer GetById(int key)
        {
            return context.Set<UserAnswer>().FirstOrDefault(t => t.Id == key)?.ToDalUserAnswer();
        }
        public DalUserAnswer GetDalUserAnswerEntityByResultIdAndQuestionId(int resultId, int questionId)
        {
            return context.Set<UserAnswer>().FirstOrDefault(t => t.ResultId == resultId && t.QuestionId == questionId)?.ToDalUserAnswer();
        }
        public DalUserAnswer GetByPredicate(Expression<Func<DalUserAnswer, bool>> f)
        {
            return context.Set<UserAnswer>().Select(t => t.ToDalUserAnswer()).FirstOrDefault(f);
        }

        public void Update(DalUserAnswer entity)
        {
            var tmp = context.Set<UserAnswer>().SingleOrDefault(t => t.Id == entity.Id);

            if (tmp != null)
                return;
            tmp = entity.ToUserAnswer();
            context.Entry(tmp).State = EntityState.Modified;
        }
    }
}
