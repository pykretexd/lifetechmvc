using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LifeTechMVC.Startup))]
namespace LifeTechMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
