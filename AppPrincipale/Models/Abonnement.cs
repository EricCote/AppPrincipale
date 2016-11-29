using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppPrincipale.Models
{
    public class Abonnement
    {
        public int AbonnementID { get; set; }
        [Required(ErrorMessage = "Nom Obligatoire")]
        public string Nom { get; set; }
        [Required(ErrorMessage = "Courriel obligatoire!")]
        [EmailAddress(ErrorMessage = "Courriel invalide!")]
        public string Courriel { get; set; }
        public bool Actif { get; set; }
    }
}