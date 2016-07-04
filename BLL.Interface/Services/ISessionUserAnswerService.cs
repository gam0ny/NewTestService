using BLL.Interface.Entities;
using System;
using System.Collections.Generic;

namespace BLL.Interface.Services
{
    public interface ISessionUserAnswerService
    {
        bool AddTmpItem(int id, int questionId, bool correct, int cost);
        void RemoveTmpItem(int id);
        void Clear();
        void StartTest(int testId, int time);
        void EndTest();
        IEnumerable<TmpUserAnswerEntity> Result { get; }
        int TestId { get; }
    }
}
