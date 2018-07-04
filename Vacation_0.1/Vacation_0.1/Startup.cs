using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vacation_0._1.Startup))]
namespace Vacation_0._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
