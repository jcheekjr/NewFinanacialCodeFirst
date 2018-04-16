using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NewFinanacialCodeFirst.Startup))]
namespace NewFinanacialCodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
