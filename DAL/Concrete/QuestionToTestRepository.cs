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
    public class QuestionToTestRepository : IQuestionToTestRepository
    {
        private DbContext context;
        public QuestionToTestRepository(DbContext context)
        {
            this.context = context;
        }
        public void Create(DalQuestionToTest e)
        {
            if (e == null) return;
            var test = e.ToQuestionToTest();
            context.Set<QuestionToTest>().Add(test);
        }

        public void Delete(int id)
        {
            var test = context.Set<QuestionToTest>().SingleOrDefault(t => t.Id == id);
            if (test != default(QuestionToTest))
                context.Set<QuestionToTest>().Remove(test);
        }

        public IEnumerable<DalQuestionToTest> GetAll()
        {
            return context.Set<QuestionToTest>().ToList().Select(t => t.ToDalQuestionToTest());
        }

        public DalQuestionToTest GetById(int key)
        {
            return context.Set<QuestionToTest>().FirstOrDefault(t => t.Id == key)?.ToDalQuestionToTest();
        }



        public void Update(DalQuestionToTest entity)
        {
            if (entity == null) return;
            var test = context.Set<QuestionToTest>().SingleOrDefault(t => t.Id == entity.Id);

            if (test == default(QuestionToTest))
            {
                test = entity.ToQuestionToTest();
                context.Set<QuestionToTest>().Add(test);
                return;
            }
            test.QuestionId = entity.QuestionId;
            test.TestId = entity.TestId;

            context.Entry(test).State = EntityState.Modified;
        }
    }
}
