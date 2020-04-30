using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExternalAuth.Startup))]
namespace ExternalAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
