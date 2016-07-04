using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface.Entities
{
    public class QuestionEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Cost { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public bool IsDelete { get; set; }
    }
}
