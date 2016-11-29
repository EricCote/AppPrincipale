using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AppPrincipale.Startup))]
namespace AppPrincipale
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
