using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnet_mvc_authentications.Startup))]
namespace aspnet_mvc_authentications
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
