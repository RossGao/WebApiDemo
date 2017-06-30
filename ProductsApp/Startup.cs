using System.Web.Http;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;

[assembly: OwinStartup(typeof(ProductsApp.ResourceServer.Startup))]
namespace ProductsApp.ResourceServer
{
    /// <summary>
    /// The assebmly should use owin middleware and start at running the Startup method.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Method is used to setup pipeline middlewares when server is up.
        /// </summary>
        /// <param name="app">Instance of IAppBuilder</param>
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            ConfigureOAuth(app);                    // set api authentication schema.
            UnityConfig.RegisterComponents(config); // Use unity as ioc container. Global dependency resolver.
            WebApiConfig.Register(config);          // Setup web api route policy.
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);  // Use Cors in message handling.
            app.UseWebApi(config);                  // Use web api.
        }

        private void ConfigureOAuth(IAppBuilder app)
        {
            // Token Consumption
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions
            {
            });
        }
    }
}