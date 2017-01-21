using Microsoft.Practices.Unity;
using System.Web.Http;
using Services;
using Unity.WebApi;
using Dal;
using Contracts.IServices;
using Services.Services;

namespace WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            UnityContainerConfig.Configure(container);
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}