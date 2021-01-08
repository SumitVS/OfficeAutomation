using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OfficeAutomation.Startup))]
namespace OfficeAutomation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
