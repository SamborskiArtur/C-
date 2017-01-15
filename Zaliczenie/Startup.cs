using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zaliczenie.Startup))]
namespace Zaliczenie
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
