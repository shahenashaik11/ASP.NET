using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_26nov.Startup))]
namespace _26nov
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
