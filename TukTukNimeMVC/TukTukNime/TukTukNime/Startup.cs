using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TukTukNime.Startup))]
namespace TukTukNime
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
