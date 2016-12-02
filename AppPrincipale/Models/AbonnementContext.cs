using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppPrincipale.Models
{
    public class AbonnementContext  : DbContext
    {
        public AbonnementContext() : base("AbonnementsBd2")
        { }

        public DbSet<Abonnement> Abonnements { get; set; }
        public DbSet<Commentaire> Commentaires { get; set; }
        
    }
}