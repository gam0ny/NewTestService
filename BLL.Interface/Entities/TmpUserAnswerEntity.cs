namespace BLL.Interface.Entities
{
    public class TmpUserAnswerEntity
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public bool Correct { get; set; }
        public int Cost { get; set; }
    }
}
