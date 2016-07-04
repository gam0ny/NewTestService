using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class QuestionAnswer
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public bool Correct { get; set; }
        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
        public virtual ICollection<UserAnswer> UserAnswers { get; set; }
        public QuestionAnswer()
        {
            UserAnswers = new HashSet<UserAnswer>();
        }
    }
}
