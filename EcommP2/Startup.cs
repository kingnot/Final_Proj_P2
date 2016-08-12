using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EcommP2.Startup))]
namespace EcommP2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
