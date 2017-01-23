using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eProto.Startup))]
namespace eProto
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
