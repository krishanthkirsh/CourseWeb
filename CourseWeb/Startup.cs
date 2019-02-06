using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CourseWeb.Startup))]
namespace CourseWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
