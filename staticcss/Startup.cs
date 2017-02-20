using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(staticcss.Startup))]
namespace staticcss
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
