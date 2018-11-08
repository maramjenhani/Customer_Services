using Customer_service.Areas.administrateur.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Customer_service.Areas.administrateur.Controllers
{
    public class DashboardController : Controller

       


    {
        // GET: administrateur/Dashboard
        public ActionResult Accueil()
        {
           
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Produit()
        {
            return View();
        }
       
       
}