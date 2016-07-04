using MvcPL.Models.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPL.Models.Result
{
    public class TestResultViewModel
    {
        public ResultViewModel Resul { get;set;}
        public TestViewModel Test { get; set; }
    }
}