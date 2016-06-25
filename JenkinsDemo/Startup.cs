using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsDemo.Startup))]
namespace JenkinsDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
