using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LoremIpsum.Web.Startup))]
namespace LoremIpsum.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
