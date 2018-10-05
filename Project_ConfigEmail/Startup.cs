using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Project_ConfigEmail.Startup))]
namespace Project_ConfigEmail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
