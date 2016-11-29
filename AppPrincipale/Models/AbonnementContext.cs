using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppPrincipale.Models
{
    public class AbonnementContext  : DbContext
    {
        public AbonnementContext() : base("AbonnementsBd")
        { }

        public DbSet<Abonnement> Abonnements { get; set; }
    }
}