using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab8MVC.Startup))]
namespace Lab8MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
