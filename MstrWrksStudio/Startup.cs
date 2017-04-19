using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MstrWrksStudio.Startup))]
namespace MstrWrksStudio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
