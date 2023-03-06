using Owin;
using Microsoft.Owin;
using Microsoft.AspNet.SignalR.StockTicker;

[assembly: OwinStartup(typeof(Startup))]
namespace Microsoft.AspNet.SignalR.StockTicker
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureSignalR(app);
        }

        public static void ConfigureSignalR(IAppBuilder app)
        {
            HubConfiguration hubConfiguration = new HubConfiguration();
            hubConfiguration.EnableDetailedErrors = true;
            app.MapSignalR(hubConfiguration);
        }
    }
}