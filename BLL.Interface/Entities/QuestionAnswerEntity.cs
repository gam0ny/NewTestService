namespace BLL.Interface.Entities
{
    public class QuestionAnswerEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool Correct { get; set; }
        public int QuestionId { get; set; }
    }
}
