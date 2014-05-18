using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BestSoftwareWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Модифицируйте этот шаблон для старта вашего ASP.NET MVC приложения.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Описание вашей страницы приложения.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Ваша страница с контактами.";

            return View();
        }
    }
}
