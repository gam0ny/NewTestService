using BLL.Interface.Entities;
using BLL.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Interface.Repository;
using BLL.Mappers;

namespace BLL.Services
{

    public class UserAnswerService : IUserAnswerService
    {
        private readonly IUnitOfWork uow;
        private readonly IResultService resultService;

        public UserAnswerService(IUnitOfWork uow, IResultService resultService)
        {
            this.uow = uow;
            this.resultService = resultService;
        }
        public UserAnswerEntity GetTestEntity(int id)
        {
            return uow.UserAnswerRepository.GetById(id).ToBllUserAnswer();
        }
        public UserAnswerEntity GetUserAnswerEntityByResultIdAndQuestionId(int resultId, int questionId)
        {
            return uow.UserAnswerRepository.GetDalUserAnswerEntityByResultIdAndQuestionId(resultId, questionId)?.ToBllUserAnswer();
        }
        public ISessionUserAnswerService CreateNewSessionAnswer()
        {
            SessionUserAnswerService tmpUserAnswer = new SessionUserAnswerService();
            return tmpUserAnswer;
        }
        public int EndTest(ISessionUserAnswerService result)
        {
            List<UserAnswerEntity> questionAnswers = new List<UserAnswerEntity>();
            int mark = 0;
            foreach (var sas in result.Result)
            {
                if (sas.Correct)
                    mark += sas.Cost;
            }
            DateTime date = DateTime.Now;
            int userId = 1;
            ResultEntity testResult = new ResultEntity { UserId = userId, TestId = result.TestId, Mark = mark, Date = date };
            uow.ResultRepository.Create(testResult.ToDalResult());
            uow.Commit();
            int resultId = resultService.GetResultEntityByUserIdAndDate(userId, date).Id;
            foreach (var sas in result.Result)
            {
                uow.UserAnswerRepository.Create(
                    (new UserAnswerEntity { QuestionId = sas.QuestionId, QuestionAnswerId = sas.Id, ResultId = resultId })
                    .ToDalUserAnswer());
            }
            uow.Commit();
            return resultId;
        }

    }
}
