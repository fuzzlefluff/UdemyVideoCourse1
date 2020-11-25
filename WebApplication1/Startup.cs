using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UdemyVideoSite.Startup))]
namespace UdemyVideoSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
