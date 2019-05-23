using CommonProject.Domain.Services.TestFacade;
using CommonProject.Domain.Services.TestFacade.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Common.MVC.Controllers
{
    public class TestConnectController : Controller
    {
        ITestService _testService = new TestService();

        //public TestConnectController(ITestService testService)
        //{
        //    _testService = testService;
        //}

      
        // GET: TestConnect
        public ActionResult Index()
        {
            var result = _testService.GetAll();
            return View();
        }

        public ActionResult GetAll()
        {
            var result = _testService.GetAll();
            return View();
        }
    }
}