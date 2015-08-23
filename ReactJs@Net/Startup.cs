using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReactJs_Net.Startup))]
namespace ReactJs_Net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
