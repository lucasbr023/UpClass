using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UpClass.Startup))]
namespace UpClass
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
