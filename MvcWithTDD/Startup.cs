using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcWithTDD.Startup))]
namespace MvcWithTDD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
