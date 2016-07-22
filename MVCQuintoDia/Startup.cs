using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCQuintoDia.Startup))]
namespace MVCQuintoDia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
