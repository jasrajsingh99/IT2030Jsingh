using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCEventApplication.Startup))]
namespace MVCEventApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
