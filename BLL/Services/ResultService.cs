using BLL.Interface.Entities;
using BLL.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Interface.Repository;
using BLL.Mappers;

namespace BLL.Services
{
    public class ResultService : IResultService
    {
        private readonly IUnitOfWork uow;

        public ResultService(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public ResultEntity GetResultEntityById(int id)
        {
            return uow.ResultRepository.GetById(id).ToBllResult();
        }

        public IEnumerable<ResultEntity> GetResultEntityByUserId(int userId)
        {
            return uow.ResultRepository.GetDalQuestionByUserId(userId).Select(q => q.ToBllResult());
        }
        public ResultEntity GetResultEntityByUserIdAndDate(int userId, DateTime date)
        {
            return uow.ResultRepository.GetDalResultByUserIdAndDate(userId, date).ToBllResult();
        }
    }
}
