using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RedNuc.Startup))]
namespace RedNuc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
