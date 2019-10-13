using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssignmentPorfolio_Flybook_V2.Startup))]
namespace AssignmentPorfolio_Flybook_V2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
