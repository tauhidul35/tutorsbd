using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tutorsbd.Startup))]
namespace tutorsbd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
