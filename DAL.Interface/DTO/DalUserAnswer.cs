namespace DAL.Interface.DTO
{
    public class DalUserAnswer : IEntity
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int QuestionAnswerId { get; set; }
        public int ResultId { get; set; }
    }
}
