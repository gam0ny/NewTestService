using BLL.Interface.Services;
using MvcPL.Models.Result;
using MvcPL.Infrastructure.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcPL.Models;

namespace MvcPL.Controllers
{
    [Authorize]
    public class ResultController : Controller
    {
        //private IQuestionService QuestionService;
        //private IQuestionAnswerService QuestionAnswerService;
        //private IUserAnswerService UserAnswerService;
        //private IResultService ResultService;
        //private ITestService TestService;
        //private int PageSize = 1;
        //public ResultController(IQuestionService questionService, IQuestionAnswerService questionAnswerService,
        //    IUserAnswerService userAnswerService, IResultService resultService, ITestService testService)
        //{
        //    this.QuestionService = questionService;
        //    this.QuestionAnswerService = questionAnswerService;
        //    this.UserAnswerService = userAnswerService;
        //    this.ResultService = resultService;
        //    this.TestService = testService;
        //}
        //public ActionResult ShowResult(int resultId)
        //{
        //    TestResultViewModel model = new TestResultViewModel
        //    {
        //        Resul = ResultService.GetResultEntityById(resultId).ToMvcResult(),
        //        Test = TestService.GetTestEntity(ResultService.GetResultEntityById(resultId)
        //        .ToMvcResult().TestId).ToMvcTest()
        //    };
        //    return View(model);
        //}
        //public ActionResult ShowDetails(int resultId, int testId, int page = 1)
        //{
        //    TempData["ResultId"] = resultId;
        //    int currentQusetionId = QuestionService.GetQuestionEntityByTestId(testId).Where(q => q.Number == page).Select(q => q.ToMVCQuestion()).First().Id;
        //    int? currentAnswerId = UserAnswerService.GetUserAnswerEntityByResultIdAndQuestionId(resultId,currentQusetionId)?.QuestionAnswerId;
        //    TestResultDetailsViewModel model = new TestResultDetailsViewModel
        //    {
        //        Questions = QuestionService.GetQuestionEntityByTestId(testId)
        //        .OrderBy(p => p.Number)
        //        .Skip((page - 1) * PageSize)
        //        .Take(PageSize).Select(q => q.ToMVCQuestion()),
        //        QuestionInfo = new PagingInfo
        //        {
        //            CurrentPage = page,
        //            ItemsPerPage = PageSize,
        //            TotalItems = QuestionService.GetQuestionEntityByTestId(testId).Select(q => q.ToMVCQuestion()).Count()
        //        },
        //        QuestionAnswers = QuestionAnswerService.GetQuestionAnswerEntityById(currentQusetionId)?.ToMvcQuestionAnswer(),
        //    };
        //    return View(model);
        //}
        //public ActionResult ViewStatistic(int userId)
        //{
        //    AllTestResultViewModel model = new AllTestResultViewModel
        //    {
        //        Results=ResultService.GetResultEntityByUserId(userId).Select(r=>r.ToMvcResult())
        //    };
        //    return PartialView(model);
        //}

    }
}
