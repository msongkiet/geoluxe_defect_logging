using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(geoluxe_defect_logging.Startup))]
namespace geoluxe_defect_logging
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
