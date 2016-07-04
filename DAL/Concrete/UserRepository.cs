using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using DAL.Interface.DTO;
using DAL.Interface.Repository;
using ORM;
using DAL.Mappers;

namespace DAL.Concrete
{
    public class UserRepository : IUserRepository
    {
        private DbContext context;
        public UserRepository(DbContext context)
        {
            this.context = context;
        }
        public void Create(DalUser e)
        {
            if (e == null) return;
            var test = e.ToUser();
            context.Set<User>().Add(test);
        }

        public void Delete(int id)
        {
            var test = context.Set<User>().SingleOrDefault(t => t.Id == id);
            if (test != default(User))
                context.Set<User>().Remove(test);
        }

        public IEnumerable<DalUser> GetAll()
        {
            return context.Set<User>().ToList().Select(t => t.ToDalUser());
        }

        public DalUser GetById(int key)
        {
            return context.Set<User>().FirstOrDefault(t => t.Id == key)?.ToDalUser();
        }



        public void Update(DalUser entity)
        {
            if (entity == null) return;
            var test = context.Set<User>().SingleOrDefault(t => t.Id == entity.Id);

            if (test == default(User))
            {
                test = entity.ToUser();
                context.Set<User>().Add(test);
                return;
            }
            test.Name = entity.Name;
            test.Surname = entity.Surname;
            test.Email = entity.Email;
            test.Password = entity.Password;
            test.PhotoData = entity.PhotoData;
            test.PhotoMimeType = entity.PhotoMimeType;
            test.CreationDate = entity.CreationDate;
            test.StudyGroupId = entity.StudyGroupId;

            context.Entry(test).State = EntityState.Modified;
        }
    }
}