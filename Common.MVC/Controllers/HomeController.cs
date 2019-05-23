using CommonProject.Domain.Services.TestFacade;
using CommonProject.Domain.Services.TestFacade.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Common.MVC.Controllers
{
    public class HomeController : Controller
    {
        ITestService _testService = new TestService();

       

        //public HomeController()
        //{
                
        //}
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }
    }
}