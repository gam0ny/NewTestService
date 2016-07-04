using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcPL.Infrastructure
{
    public interface IPagingInfo
    {
        int TotalItems { get; set; }
        int CurrentPage { get; set; }
    }
}
