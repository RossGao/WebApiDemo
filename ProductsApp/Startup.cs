using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System.Web.Http;

[assembly: OwinStartup(typeof(ProductsApp.ResourceServer.Startup))]
namespace ProductsApp.ResourceServer
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            UnityConfig.RegisterComponents(config); // Use unity as ioc container. Global dependency resolver.
            ConfigureOAuth(app);                    // set api authentication schema.
            WebApiConfig.Register(config);          // Setup web api route policy.
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);  // Use Cors in message handling.
            app.UseWebApi(config);                  // Use web api.
        }

        private void ConfigureOAuth(IAppBuilder app)
        {
            //Token Consumption
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions
            {
            });
        }
    }
}