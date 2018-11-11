using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Customer_service.Areas.administrateur.Controllers
{
    public class DashboardController : Controller




    {
        //[Authorize(Roles ="admin")]
        // GET: administrateur/Dashboard
        public ActionResult Index()
        {
            //return RedirectToAction("Login");

            return View();
        }
        public ActionResult Login()
        {
            return View();
        }



    }
}