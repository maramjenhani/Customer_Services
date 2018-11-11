using Customer_service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Customer_service.Areas.administrateur.Controllers
{
    public class EditProductController : Controller
    {
        dotnetEntities1 db = new dotnetEntities1();
        // GET: administrateur/EditProduct
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(Produit p)
        {
            try
            {
                using (dotnetEntities1 db = new Models.dotnetEntities1())
                {
                    db.Produit.Add(p);
                    db.SaveChanges();
                 
                }
                return RedirectToAction("_LayoutAdmin");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit()
        {
            Models.dotnetEntities1 db = new Models.dotnetEntities1();
            //Models.Produit p = db.Produit.SingleOrDefault(x => x.@ref == 1);
            //Models.ProduitViewModel pvm = new Models.ProduitViewModel();
            ////pvm.@ref = p.@ref;
            //pvm.designation = p.designation;
            //pvm.description = p.description;
            //pvm.couleur = p.couleur;
            //pvm.prix = p.prix;
            //pvm.photo = p.photo;


            return View(db.Produit.ToList());
        }
        //[HttpGet]
        //public ActionResult save(int id)
        //{
        //    //using (dotnetEntities db = new dotnetEntities())
        //    //{ }
        //    return View();
        //}

        [HttpGet]
        public ActionResult Delete(int id)
        {
            using (Models.dotnetEntities1 db = new Models.dotnetEntities1())
            {
                var v = db.Produit.Where(a => a.@ref == id).FirstOrDefault();
                if (v != null)
                {
                    return View(v);
                }
                else
                {
                    return HttpNotFound();
                }
            }
        }


    }
}
