using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Customer_service.Areas.administrateur.Controllers
{
    public class EditProductController : Controller
    {
        // GET: administrateur/EditProduct
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult save(int id)
        {
            //using (dotnetEntities db = new dotnetEntities())
            //{ }
            return View();
        }
        public ActionResult Delete()
        {
             return RedirectToAction("Index");
        }
        public ActionResult Update()
        {
            return RedirectToAction("Index");
        }

        public ActionResult lister()
        {
            return RedirectToAction("Index");
        }

    }
}
