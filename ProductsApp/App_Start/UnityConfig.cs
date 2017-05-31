using Microsoft.Practices.Unity;
using ProductsApp.BLL;
using ProductsApp.DAL;
using ProductsApp.Interface;
using System.Web.Http;
using Unity.WebApi;

namespace ProductsApp
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IProductBusinessHandler, ProductBusinessHandler>();
            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}