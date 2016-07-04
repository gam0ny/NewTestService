using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcPL.Models.Test
{
    public class TestsListViewModel
    {
        public IEnumerable<TestViewModel> Tests { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}