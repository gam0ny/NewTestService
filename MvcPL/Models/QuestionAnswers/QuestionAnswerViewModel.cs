using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPL.Models.Question
{
    public class QuestionAnswerViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter content of the answer")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Please select option")]
        public bool Correct { get; set; }
        public int QuestionId { get; set; }
    }
}