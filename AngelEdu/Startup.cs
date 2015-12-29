using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AngelEdu.Startup))]
namespace AngelEdu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
