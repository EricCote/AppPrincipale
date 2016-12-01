using AppPrincipale.Filters;
using System.Web;
using System.Web.Mvc;

namespace AppPrincipale
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            HandleErrorAttribute monErreur = new HandleErrorAttribute();
            monErreur.View = "Erreur2"; 
            filters.Add(monErreur);


            //LanguageAttribute langue = new LanguageAttribute("fr-CA");
            //filters.Add(langue);

        }
    }
}
