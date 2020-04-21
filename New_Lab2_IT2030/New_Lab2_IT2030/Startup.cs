using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(New_Lab2_IT2030.Startup))]
namespace New_Lab2_IT2030
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
