using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PeopleAPI.Startup))]
namespace PeopleAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
