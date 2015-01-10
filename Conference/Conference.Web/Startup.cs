using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Conference.Web.Startup))]
namespace Conference.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
