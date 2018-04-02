using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrySaml.Startup))]
namespace TrySaml
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
