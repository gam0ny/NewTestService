using System;

namespace BLL.Interface.Entities
{
    public class QuestionToTestEntity
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int TestId { get; set; }
    }
}
