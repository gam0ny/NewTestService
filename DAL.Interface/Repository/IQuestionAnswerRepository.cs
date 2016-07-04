using DAL.Interface.DTO;
using DAL.Interface.Repository;
using System.Collections.Generic;

namespace DAL.Interfacies.Repository
{
    public interface IQuestionAnswerRepository : IRepository<DalQuestionAnswer>
    {
        IEnumerable<DalQuestionAnswer> GetDalQuestionAnswerByQuestionId(int questionId);
    }
}
