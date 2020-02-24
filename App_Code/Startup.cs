using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(project_pos.Startup))]
namespace project_pos
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
