using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VShopApp.Startup))]
namespace VShopApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
