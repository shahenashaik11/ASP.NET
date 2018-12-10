using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CheckBoxGeneration.Startup))]
namespace CheckBoxGeneration
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
