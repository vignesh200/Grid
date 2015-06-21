using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Grid.Startup))]
namespace Grid
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
