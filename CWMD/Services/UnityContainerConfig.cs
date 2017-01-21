using Contracts.IServices;
using Dal;
using Microsoft.Practices.Unity;
using Services.Services;

namespace Services
{
    public static class UnityContainerConfig
    {
        public static void Configure(IUnityContainer container)
        {
            container.RegisterType<IMyDbContext, MyDbContext>();
            container.RegisterType<IUserService, UserService>();
        }
    }
}
