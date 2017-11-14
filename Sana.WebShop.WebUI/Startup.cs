using Microsoft.Owin;
using Owin;
using Sana.WebShop.WebUI;

[assembly: OwinStartup(typeof(Startup))]

namespace Sana.WebShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
