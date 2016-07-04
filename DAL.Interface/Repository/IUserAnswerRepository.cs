using DAL.Interface.DTO;
using DAL.Interface.Repository;

namespace DAL.Interfacies.Repository
{
    public interface IUserAnswerRepository:IRepository<DalUserAnswer>
    {
        DalUserAnswer GetDalUserAnswerEntityByResultIdAndQuestionId(int resultId, int questionId);
    }
}
