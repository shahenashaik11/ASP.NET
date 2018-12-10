using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExamCheck.Startup))]
namespace ExamCheck
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
