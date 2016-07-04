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
    public class UsersToRoleRepository : IUsersToRoleRepository
    {
        private DbContext context;
        public UsersToRoleRepository(DbContext context)
        {
            this.context = context;
        }
        public void Create(DalUsersToRole e)
        {
            if (e == null) return;
            var test = e.ToUsersToRole();
            context.Set<UsersToRole>().Add(test);
        }

        public void Delete(int id)
        {
            var test = context.Set<UsersToRole>().SingleOrDefault(t => t.Id == id);
            if (test != default(UsersToRole))
                context.Set<UsersToRole>().Remove(test);
        }

        public IEnumerable<DalUsersToRole> GetAll()
        {
            return context.Set<UsersToRole>().ToList().Select(t => t.ToDalUsersToRole());
        }

        public DalUsersToRole GetById(int key)
        {
            return context.Set<UsersToRole>().FirstOrDefault(t => t.Id == key)?.ToDalUsersToRole();
        }



        public void Update(DalUsersToRole entity)
        {
            if (entity == null) return;
            var test = context.Set<UsersToRole>().SingleOrDefault(t => t.Id == entity.Id);

            if (test == default(UsersToRole))
            {
                test = entity.ToUsersToRole();
                context.Set<UsersToRole>().Add(test);
                return;
            }
            test.RoleId = entity.RoleId;
            test.UserId = entity.UserId;

            context.Entry(test).State = EntityState.Modified;
        }
    }
}
