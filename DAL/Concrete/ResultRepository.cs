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
    public class ResultRepository : IResultRepository
    {
        private DbContext context;
        public ResultRepository(DbContext context)
        {
            this.context = context;
        }
        public void Create(DalResult e)
        {
            if (e == null) return;
            var tmp = e.ToResult();
            context.Set<Result>().Add(tmp);
        }

        public void Delete(int id)
        {
            var tmp = context.Set<Result>().SingleOrDefault(t => t.Id == id);
            if (tmp != default(Result))
                context.Set<Result>().Remove(tmp);
        }

        public IEnumerable<DalResult> GetAll()
        {
            return context.Set<Result>().ToList().Select(t => t.ToDalResult());
        }

        public DalResult GetById(int key)
        {
            return context.Set<Result>().FirstOrDefault(t => t.Id == key)?.ToDalResult();
        }
        public IEnumerable<DalResult> GetDalQuestionByUserId(int userId)
        {
            return context.Set<Result>().Where(t => t.UserId == userId).ToList().Select(t => t.ToDalResult());
        }
        public DalResult GetDalResultByUserIdAndDate(int userId, DateTime date)
        {
            return context.Set<Result>().FirstOrDefault(t => t.UserId == userId && t.Date==date)?.ToDalResult();
        }
        public DalResult GetByPredicate(Expression<Func<DalResult, bool>> f)
        {
            return context.Set<Result>().Select(t => t.ToDalResult()).FirstOrDefault(f);
        }

        public void Update(DalResult entity)
        {
            var tmp = context.Set<Result>().SingleOrDefault(t => t.Id == entity.Id);

            if (tmp != null)
                return;
            tmp = entity.ToResult();
            context.Entry(tmp).State = EntityState.Modified;
        }
    }
}
