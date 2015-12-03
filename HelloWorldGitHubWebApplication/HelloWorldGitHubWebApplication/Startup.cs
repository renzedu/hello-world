using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloWorldGitHubWebApplication.Startup))]
namespace HelloWorldGitHubWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
