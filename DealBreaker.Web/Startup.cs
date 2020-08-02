using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DealBreaker.Web.Startup))]
namespace DealBreaker.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
