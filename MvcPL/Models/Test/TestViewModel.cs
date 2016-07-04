using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPL.Models.Test
{
    public class TestViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a number of test")]
        public int Number { get; set; }
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Please enter a test name")]
        public string Name { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a positive integer number")]
        public long TimeToDo { get; set; }
    }
}