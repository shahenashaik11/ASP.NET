using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineExamPortal.Startup))]
namespace OnlineExamPortal
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
