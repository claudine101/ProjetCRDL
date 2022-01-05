using ApplicationWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationWeb.Controllers
{
    public class CategorieController : Controller
    {
        //
        // GET: /Categorie/
        private aspnetmvc_dbEntities1 db = new aspnetmvc_dbEntities1();
        public ActionResult Index()
        {
            return View(db.categories.ToList());
        }
        public ActionResult   create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult create([Bind(Include="ID,NomCategorie")]categorie categorie)
        {
            if(ModelState.IsValid)
            {
                db.categories.Add(categorie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
         
            return View(categorie);
          }

    }
}
