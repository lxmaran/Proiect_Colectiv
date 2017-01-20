using Autofac;
using Autofac.Integration.WebApi;
using Contracts.IServices;
using Dal;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace WebApi.App_Start
{
    public class AutofacConfig
    {
        public static void ResolveComponents(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();

            builder.Register(c => new MyDbContext())
                .As<IMyDbContext>()
                .InstancePerRequest();

            builder.RegisterGeneric(typeof(BaseEntityRepository<>))
                .As(typeof(IBaseEntityRepository<>))
                .InstancePerRequest();

            builder.Register(c => new UserRepository(c.Resolve<IMyDbContext>()))
                .As<IUserRepository>()
                .InstancePerRequest();

            builder.Register(c => new UserService(c.Resolve<IUserRepository>(), c.Resolve<IBaseEntityRepository<Person>>()))
                .As<IUserService>()
                .InstancePerRequest();


            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            var container = builder.Build();
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}