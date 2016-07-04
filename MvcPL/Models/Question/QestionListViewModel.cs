using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPL.Models.Question
{
    
    public class QestionListViewModel
    {
        public IEnumerable<QuestionViewModel> Questions { get; set; }
        public IEnumerable<QuestionAnswerViewModel> QuestionAnswers { get; set; }
        public PagingInfo QuestionInfo { get; set; }
    }
}