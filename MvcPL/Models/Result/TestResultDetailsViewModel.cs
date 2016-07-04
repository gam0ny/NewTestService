using MvcPL.Models.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPL.Models.Result
{
    public class TestResultDetailsViewModel
    {
        public IEnumerable<QuestionViewModel> Questions { get; set; }
        public QuestionAnswerViewModel QuestionAnswers { get; set; }
        public PagingInfo QuestionInfo { get; set; }
    }
}