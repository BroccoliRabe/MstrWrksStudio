using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MstrWrksStudio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ToDo()
        {
            ViewBag.Message = "Your application description page.";
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction("Login", "Account");
            return View("Todo");
        }

        public ActionResult Channels()
        {

            ViewBag.Message = "Your contact page.";
            if (!User.Identity.IsAuthenticated)
                return RedirectToAction("Login", "Account");
            return RedirectToAction("ChannelList", "Channel");
        }
    }
}