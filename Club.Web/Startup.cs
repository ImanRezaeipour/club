using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Club.Web.Startup))]
namespace Club.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
