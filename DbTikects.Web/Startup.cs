using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DbTikects.Web.Startup))]
namespace DbTikects.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
