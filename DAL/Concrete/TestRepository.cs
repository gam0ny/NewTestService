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
    public class TestRepository : ITestRepository
    {
        private DbContext context;
        public TestRepository(DbContext context)
        {
            this.context = context;
        }
        public void Create(DalTest e)
        {
            if (e == null) return;
            var test = e.ToTest();
            context.Set<Test>().Add(test);
        }

        public void Delete(int id)
        {
            var test = context.Set<Test>().SingleOrDefault(t => t.Id == id);
            if (test != default(Test))
                context.Set<Test>().Remove(test);
        }

        public IEnumerable<DalTest> GetAll()
        {
            return context.Set<Test>().ToList().Select(t => t.ToDalTest());
        }

        public DalTest GetById(int key)
        {
            return context.Set<Test>().FirstOrDefault(t => t.Id == key)?.ToDalTest();
        }

        public DalTest GetByPredicate(Expression<Func<DalTest, bool>> f)
        {
            return context.Set<Test>().Select(t => t.ToDalTest()).FirstOrDefault(f);
        }

        public void Update(DalTest entity)
        {
            if (entity == null) return;
            var test = context.Set<Test>().SingleOrDefault(t => t.Id == entity.Id);

            if (test == default(Test))
            {
                test = entity.ToTest();
                context.Set<Test>().Add(test);
                return;
            }
            test.Name = entity.Name;
            test.UserId = entity.UserId;
            test.TimeToDo = entity.TimeToDo;
            test.Publish = entity.Publish;
            test.IsDelete = entity.IsDelete;
            test.MarkToSuccess = entity.MarkToSuccess;
            
            context.Entry(test).State = EntityState.Modified;
        }

    }
}
