using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary1;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private IMyService1 objService;

        public HomeController(IMyService1 tempService)
        {
            this.objService = tempService;
        }

        public ActionResult Index()
        {
            objService.SendData();
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        
    }
}