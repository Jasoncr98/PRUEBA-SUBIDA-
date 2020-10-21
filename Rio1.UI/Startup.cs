using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rio1.UI.Startup))]
namespace Rio1.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
