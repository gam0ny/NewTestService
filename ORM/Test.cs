using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Test
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public long TimeToDo { get; set; }
        [Required]
        public string Name { get; set; }
        public bool Publish { get; set; }
        public bool IsDelete { get; set; }
        public int MarkToSuccess { get; set; }
        public DateTime Date { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Result> Results { get; set; }
        public virtual ICollection<QuestionToTest> QuestionToTests { get; set; }
        public Test()
        {
            Results = new HashSet<Result>();
            QuestionToTests = new HashSet<QuestionToTest>();
        }
    }
}
