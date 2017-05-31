using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Microsoft.Practices.Unity;
using ProductsApp.Interface;
using ProductsApp.BLL;
using ProductsApp.DAL;

namespace ProductsApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            // Regist dependencies into container overhere
            //var container = new UnityContainer();
            //container.RegisterType<IProductRepository, ProductRepository>();
            //container.RegisterType<IProductBusinessHandler, ProductBusinessHandler>();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
        }
    }
}
