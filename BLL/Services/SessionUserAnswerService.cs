using BLL.Interface.Entities;
using BLL.Interface.Services;
using DAL.Interface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class SessionUserAnswerService : ISessionUserAnswerService
    {
        private List<TmpUserAnswerEntity> tmpUserAnswer = new List<TmpUserAnswerEntity>();
        private DateTime timeBegin = new DateTime();
        private int timeToDo;
        private int testId;

        public bool AddTmpItem(int id, int questionId, bool correct, int cost)
        {
            TimeSpan timer = DateTime.Now - timeBegin;
            if (timeToDo < timer.TotalMinutes)
                return false;
            TmpUserAnswerEntity line = tmpUserAnswer
                .Where(p => p.QuestionId == questionId)
                .FirstOrDefault();

            if (line == null)
            {
                tmpUserAnswer.Add(new TmpUserAnswerEntity
                {
                    Id = id,
                    QuestionId = questionId,
                    Correct = correct,
                    Cost = cost
                });
            }
            else
            {
                tmpUserAnswer.RemoveAll(p => p.QuestionId == questionId);
                tmpUserAnswer.Add(new TmpUserAnswerEntity
                {
                    Id = id,
                    QuestionId = questionId,
                    Correct = correct,
                    Cost = cost
                });
            }
            return true;
        }
        public void StartTest(int testId, int time)
        {
            timeBegin = DateTime.Now;
            this.timeToDo = time;
            this.testId = testId;
        }
        public void RemoveTmpItem(int id)
        {
            tmpUserAnswer.RemoveAll(p => p.Id == id);
        }

        public void Clear()
        {
            tmpUserAnswer.Clear();
        }

        public void EndTest()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<TmpUserAnswerEntity> Result
        {
            get { return tmpUserAnswer; }
        }
        public int TestId
        {
            get { return testId; }
        }

    }
}
