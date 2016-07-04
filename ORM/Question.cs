using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Question
    {
        public int Id { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public int Cost { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public bool IsDelete { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<QuestionAnswer> QuestionAnswers { get; set; }
        public virtual ICollection<UserAnswer> UserAnswers { get; set; }
        public virtual ICollection<QuestionToTest> QuestionToTests { get; set; }
        public Question()
        {
            UserAnswers = new HashSet<UserAnswer>();
            QuestionAnswers = new HashSet<QuestionAnswer>();
            QuestionToTests = new HashSet<QuestionToTest>();
        }
    }
}