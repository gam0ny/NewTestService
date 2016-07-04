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
    public class RoleRepository : IRoleRepository
    {
        private DbContext context;
        public RoleRepository(DbContext context)
        {
            this.context = context;
        }
        public void Create(DalRole e)
        {
            if (e == null) return;
            var test = e.ToRole();
            context.Set<Role>().Add(test);
        }

        public void Delete(int id)
        {
            var test = context.Set<Role>().SingleOrDefault(t => t.Id == id);
            if (test != default(Role))
                context.Set<Role>().Remove(test);
        }

        public IEnumerable<DalRole> GetAll()
        {
            return context.Set<Role>().ToList().Select(t => t.ToDalRole());
        }

        public DalRole GetById(int key)
        {
            return context.Set<Role>().FirstOrDefault(t => t.Id == key)?.ToDalRole();
        }



        public void Update(DalRole entity)
        {
            if (entity == null) return;
            var test = context.Set<Role>().SingleOrDefault(t => t.Id == entity.Id);

            if (test == default(Role))
            {
                test = entity.ToRole();
                context.Set<Role>().Add(test);
                return;
            }
            test.Name = entity.Name;
            test.Description = entity.Description;

            context.Entry(test).State = EntityState.Modified;
        }
    }
}
