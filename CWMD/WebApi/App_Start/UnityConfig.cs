using Microsoft.Practices.Unity;
using System.Web.Http;
using Contracts.IServices;
using Services;
using Services.Services;
using Unity.WebApi;
using Dal;

namespace WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            UnityContainerConfig.Configure(container);

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

            container.RegisterType<IMyDbContext, MyDbContext>();
            container.RegisterType(typeof(IBaseEntityRepository<>), typeof(BaseEntityRepository<>));
        }
    }
}