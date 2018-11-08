using Customer_service.Areas.administrateur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Customer_service.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult test()
        {
            return View();
        }

        public ActionResult Admin()
        {
            string apiUri = Url.HttpRouteUrl("DefaultApi", new { controller = "admin", });
            ViewBag.ApiUrl = new Uri(Request.Url, apiUri).AbsoluteUri.ToString();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult test()
        {
     
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult GetProduit()
        {
            using (dotnetEntities db = new dotnetEntities())
            {
                var produit = db.Produit.ToList();
                return Json(new { data = produit }, JsonRequestBehavior.AllowGet);
                // return View();
            }


        }
    }
}