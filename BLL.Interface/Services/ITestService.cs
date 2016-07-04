using BLL.Interface.Entities;
using System;
using System.Collections.Generic;

namespace BLL.Interface.Services
{
    public interface ITestService
    {
        TestEntity GetTestEntity(int id);
        IEnumerable<TestEntity> GetAllTestEntity();
        void Update(TestEntity entity);
        void Delete(int id);
    }
}
