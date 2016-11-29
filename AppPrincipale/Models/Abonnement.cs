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
        [Display(Name = "Courriel Personnel")]
        [StringLength(50,MinimumLength =3)]
        [Required(ErrorMessage = "Courriel obligatoire!")]
        [EmailAddress(ErrorMessage = "Courriel invalide!")]
        public string Courriel { get; set; }
        [Validation.NAS]
        public string Nas { get; set; }
        public bool Actif { get; set; }
    }
}