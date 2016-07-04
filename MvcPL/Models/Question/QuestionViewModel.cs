using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPL.Models.Question
{
    public class QuestionViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a content of test")]
        public string Content { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a positive integer number")]
        public int Number { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a positive integer number")]
        public int Cost { get; set; }
        public int TestId { get; set; }
    }
}