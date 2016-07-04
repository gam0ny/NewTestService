using BLL.Interface.Services;
using MvcPL.Infrastructure.Mappers;
using MvcPL.Models;
using MvcPL.Models.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPL.Controllers
{
    public class TestController : Controller
    {
        //private ITestService testService;

        //public int PageSize = 4;
        
        //public TestController(ITestService testService)
        //{
        //    this.testService = testService;
        //}
        //public ActionResult Index()
        //{
        //    return PartialView();
        //}
        //[Authorize]
        //public ViewResult List(int page = 1)
        //{
        //    TestsListViewModel model = new TestsListViewModel
        //    {
        //        Tests = testService.GetAllTestEntity()
        //        .OrderBy(p => p.Number)
        //        .Skip((page - 1) * PageSize)
        //        .Take(PageSize).Select(test => test.ToMvcTest()),
        //        PagingInfo = new PagingInfo
        //        {
        //            CurrentPage = page,
        //            ItemsPerPage = PageSize,
        //            TotalItems = testService.GetAllTestEntity().Count()
        //        },
        //    };
        //    return View(model);
        //}
        

    }

    }