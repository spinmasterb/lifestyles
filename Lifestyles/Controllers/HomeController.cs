using System;
using System.Web.Mvc;
using Lifestyles.Services;

namespace Lifestyles.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOperationService _operationService;
        private readonly IOtherOperationService _otherOperationService;

        public HomeController(IOperationService operationService, IOtherOperationService otherOperationService)
        {
            _operationService = operationService;
            _otherOperationService = otherOperationService;
        }

        public ActionResult Index()
        {
            ViewBag.OperationServices = new[] { _operationService, _otherOperationService };

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This is where the fish lives.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Don't contact me.";

            return View();
        }
    }
}