namespace DAL.Interface.DTO
{
    public class DalQuestionToTest : IEntity
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int TestId { get; set; }
    }
}
