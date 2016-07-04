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
    public class StudyGroupRepository : IStudyGroupRepository
    {
        private DbContext context;
        public StudyGroupRepository(DbContext context)
        {
            this.context = context;
        }
        public void Create(DalStudyGroup e)
        {
            if (e == null) return;
            var test = e.ToStudyGroup();
            context.Set<StudyGroup>().Add(test);
        }

        public void Delete(int id)
        {
            var test = context.Set<StudyGroup>().SingleOrDefault(t => t.Id == id);
            if (test != default(StudyGroup))
                context.Set<StudyGroup>().Remove(test);
        }

        public IEnumerable<DalStudyGroup> GetAll()
        {
            return context.Set<StudyGroup>().ToList().Select(t => t.ToDalStudyGroup());
        }

        public DalStudyGroup GetById(int key)
        {
            return context.Set<StudyGroup>().FirstOrDefault(t => t.Id == key)?.ToDalStudyGroup();
        }



        public void Update(DalStudyGroup entity)
        {
            if (entity == null) return;
            var test = context.Set<StudyGroup>().SingleOrDefault(t => t.Id == entity.Id);

            if (test == default(StudyGroup))
            {
                test = entity.ToStudyGroup();
                context.Set<StudyGroup>().Add(test);
                return;
            }
            test.Name = entity.Name;
            test.Description = entity.Description;

            context.Entry(test).State = EntityState.Modified;
        }
    }
}
