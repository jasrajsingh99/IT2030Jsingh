using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(createabrandnewapplication.Startup))]
namespace createabrandnewapplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
