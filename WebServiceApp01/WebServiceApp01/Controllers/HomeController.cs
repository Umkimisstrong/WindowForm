using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServiceApp01.Models;
using WebServiceApp01.SKAPI_GRT;

namespace WebServiceApp01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            Service1 svc = new Service1();
            GRT_Model request = new GRT_Model() {
                greetingMsg = "Hi World"
            };


            ViewBag.greetingMsg = svc.greeting(request).greetingMsg;

            return View();
        }
    }
}
