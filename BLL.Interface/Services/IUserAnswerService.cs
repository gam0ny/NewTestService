using BLL.Interface.Entities;
using System;
using System.Collections.Generic;

namespace BLL.Interface.Services
{
    public interface IUserAnswerService
    {
        ISessionUserAnswerService CreateNewSessionAnswer();
        int EndTest(ISessionUserAnswerService result);
        UserAnswerEntity GetUserAnswerEntityByResultIdAndQuestionId(int resultId, int questionId);

    }
}
