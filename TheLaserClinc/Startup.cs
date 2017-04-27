using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheLaserClinc.Startup))]
namespace TheLaserClinc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
