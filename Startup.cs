using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(remoteValidation2.Startup))]
namespace remoteValidation2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
