using Customer_service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Customer_service.Areas.administrateur.Controllers
{
    public class RoleController : Controller
    {
        dotnetEntities1 context;
        public RoleController()
        {
            context = new dotnetEntities1();

        }
        // GET: administrateur/Role
        //public ActionResult Index()
        //{
        //    var Roles = context.Roles.Tolist();
        //    return View(Roles);
        //}

        //public ActionResult Create()
        //{
        //    var Role = new IdentityRole();
        //    return View();
        //}
        //public ActionResult Create(IdentityRole Role)
        //{
        //    context.Roles.Add(Role);
        //    context.SaveChanges();

        //    return RedirectToAction("Index");
        //}
    }
}