using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Komsky.Web.Startup))]
namespace Komsky.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
