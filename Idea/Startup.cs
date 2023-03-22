using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Idea_System.Startup))]
namespace Idea_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
