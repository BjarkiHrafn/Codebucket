using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VLN2_Project.Startup))]
namespace VLN2_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
