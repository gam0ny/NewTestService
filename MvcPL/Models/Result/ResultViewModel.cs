using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPL.Models.Result
{
    public class ResultViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TestId { get; set; }
        public int Mark { get; set; }
        public DateTime Date { get; set; }
    }
}