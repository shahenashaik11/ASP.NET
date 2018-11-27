using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_27nov.Startup))]
namespace _27nov
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
