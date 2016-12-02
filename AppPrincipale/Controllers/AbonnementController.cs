using AppPrincipale.Models;
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
            if (ModelState.IsValid)
            {
                Models.AbonnementContext db = new Models.AbonnementContext();
                db.Abonnements.Add(ab);
                db.SaveChanges();
                return View("Merci", "", ab.Nom);
            }
            else
            {
                ViewBag.Erreur = "Email invalide!";
                return View("Index", ab);
            }

        }

        [HttpPost()]
        public ActionResult CreerCommentaire(Commentaire commentaire)
        {
            commentaire.Date = DateTime.Now;
            if (ModelState.IsValid)
            {
                Models.AbonnementContext db = new Models.AbonnementContext();
                db.Commentaires.Add(commentaire);
                db.SaveChanges();
            }
            else
            {
                return PartialView("_erreur2");
            }
            return PartialView("_merci", commentaire);
       }
            
   }
}

