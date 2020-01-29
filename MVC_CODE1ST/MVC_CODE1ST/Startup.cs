using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_CODE1ST.Startup))]
namespace MVC_CODE1ST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
