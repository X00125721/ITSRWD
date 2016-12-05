using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ITSRWD.Startup))]
namespace ITSRWD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
