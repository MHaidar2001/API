using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Httpanfragen.Startup))]
namespace Httpanfragen
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
