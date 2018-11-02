using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetMidtermA.Startup))]
namespace DotNetMidtermA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
