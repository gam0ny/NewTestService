using BLL.Interface.Entities;
using BLL.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Interface.Repository;
using BLL.Mappers;

namespace BLL.Services
{
    public class TestService : ITestService
    {
        private readonly IUnitOfWork uow;

        public TestService(IUnitOfWork uow)
        {
            this.uow = uow;
        }


        public IEnumerable<TestEntity> GetAllTestEntity()
        {
            return uow.TestRepository.GetAll().Select(test => test.ToBllTest());
        }

        public TestEntity GetTestEntity(int id)
        {
            return uow.TestRepository.GetById(id).ToBllTest();
        }

        public void Update(TestEntity entity)
        {
            uow.TestRepository.Update(entity.ToDalTest());
            uow.Commit();
        }
        public void Delete(int id)
        {
            uow.TestRepository.Delete(id);
            uow.Commit();
        }
    }
}
