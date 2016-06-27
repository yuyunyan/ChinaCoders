using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(chinaCoders.Startup))]
namespace chinaCoders
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
