using DAL.Interface.DTO;
using DAL.Interface.Repository;
using System;
using System.Collections.Generic;

namespace DAL.Interfacies.Repository
{
    public interface IResultRepository : IRepository<DalResult>
    {
        IEnumerable<DalResult> GetDalQuestionByUserId(int userId);
        DalResult GetDalResultByUserIdAndDate(int userId, DateTime date);
    }
}
