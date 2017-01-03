using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcEspacioPleno.Startup))]
namespace MvcEspacioPleno
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
