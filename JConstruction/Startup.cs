using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JConstruction.Startup))]
namespace JConstruction
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
