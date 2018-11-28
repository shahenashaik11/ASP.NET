using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_28Nov.Startup))]
namespace _28Nov
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
