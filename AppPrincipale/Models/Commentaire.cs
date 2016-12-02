using System;
using System.ComponentModel.DataAnnotations;

namespace AppPrincipale.Models
{
    public class Commentaire
    {

        public int CommentaireID { get; set; }
        [StringLength(50)]
        public string Nom { get; set; }
        [StringLength(1000)]
        [DataType(DataType.MultilineText)]
        public string Contenu { get; set; }
        public DateTime Date { get; set; }
    }
}