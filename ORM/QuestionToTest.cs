using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class QuestionToTest
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int TestId { get; set; }
        public virtual Question Question { get; set; }
        public virtual Test Test { get; set; }
    }
}
