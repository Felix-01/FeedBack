using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FeedBack.Startup))]
namespace FeedBack
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
