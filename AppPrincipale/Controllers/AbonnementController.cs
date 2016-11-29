using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppPrincipale.Controllers
{
    public class AbonnementController : Controller
    {
        // GET: Abonnement
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult Inscription(Models.Abonnement ab)
        {
            Models.AbonnementContext db = new Models.AbonnementContext();
            db.Abonnements.Add(ab);

            try
            {
                db.SaveChanges();
            }
            catch
            {
                ViewBag.Erreur = "Email invalide!";
                return View("Index", ab);
            }
            return View("Merci", "", ab.Nom);
        }








    }
}

