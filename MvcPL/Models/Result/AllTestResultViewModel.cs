using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPL.Models.Result
{
    public class AllTestResultViewModel
    {
        public IEnumerable<ResultViewModel> Results { get; set; }
    }
}