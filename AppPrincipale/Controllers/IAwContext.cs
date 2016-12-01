using AppPrincipale.Models;
using System.Data.Entity;

namespace AppPrincipale.Controllers
{
    public interface IAwContext
    {
        DbSet<Product> Products { get; set; }

        void SaveChanges();
    }
}