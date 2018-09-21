using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KancollTuk.Startup))]
namespace KancollTuk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
