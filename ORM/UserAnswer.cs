using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class UserAnswer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int QuestionAnswerId { get; set; }
        public int ResultId { get; set; }
        public virtual Test Question { get; set; }
        public virtual Test QuestionAnswer { get; set; }
        public virtual Test Result { get; set; }
    }
}
