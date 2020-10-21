using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityProject.Startup))]
namespace EntityProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
