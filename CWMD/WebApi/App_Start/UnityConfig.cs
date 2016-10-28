using Microsoft.Practices.Unity;
using System.Web.Http;
using Contracts.IServices;
using Services;
using Services.Services;
using Unity.WebApi;

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