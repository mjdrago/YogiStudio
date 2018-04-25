using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YogiStudio.Startup))]
namespace YogiStudio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
