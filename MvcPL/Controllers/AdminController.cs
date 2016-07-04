using BLL.Interface.Services;
using MvcPL.Infrastructure.Mappers;
using MvcPL.Models.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPL.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        private IQuestionService QuestionService;
        private IQuestionAnswerService QuestionAnswerService;
        private ITestService TestService;
        public AdminController(IQuestionService questionService, IQuestionAnswerService questionAnswerService, ITestService testService)
        {
            this.QuestionService = questionService;
            this.QuestionAnswerService = questionAnswerService;
            this.TestService = testService;
    }
        public ActionResult Index()
        {
            return View(TestService.GetAllTestEntity().Select(test => test.ToMvcTest()));
        }
        public ViewResult Edit(int Id)
        {
            TestViewModel test = TestService.GetTestEntity(Id).ToMvcTest();
            return View(test);
        }
        [HttpPost]
        public ActionResult Edit(TestViewModel test)
        {
            if (ModelState.IsValid)
            {
                TestService.Update(test.ToBllTest());
                TempData["message"] = string.Format("Test {0} has been saved", test.Number);
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(test);
            }
        }
        public ViewResult Create()
        {
            return View("Edit", new TestViewModel());
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            TestService.Delete(id);
            
                TempData["message"] = string.Format("Test was deleted");
            return RedirectToAction("Index");
        }
        //public ActionResult ShowQuestions(int testId)
        //{
        ////    return View(QuestionService.GetQuestionEntityByTestId(testId).Select(test => test.ToMVCQuestion()));
        //}
    }
}
