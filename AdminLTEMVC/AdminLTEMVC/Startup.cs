using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdminLTEMVC.Startup))]
namespace AdminLTEMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
