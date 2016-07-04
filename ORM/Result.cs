using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class Result
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TestId { get; set; }
        public int Mark { get; set; }
        public DateTime Date { get; set; }
        public virtual Test User { get; set; }
        public virtual Test Test { get; set; }
        public virtual ICollection<UserAnswer> UserAnswers { get; set; }
        public Result()
        {
            UserAnswers = new HashSet<UserAnswer>();
        }
    }
}
