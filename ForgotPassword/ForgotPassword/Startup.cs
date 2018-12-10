using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ForgotPassword.Startup))]
namespace ForgotPassword
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
