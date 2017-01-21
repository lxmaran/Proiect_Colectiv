using Contracts.IServices;
using Dal;
using Microsoft.Practices.Unity;
using Services.Services;

namespace Services
{
    public static class UnityContainerConfig
    {
        public static void Configure(UnityContainer container)
        {
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IDocumentService, DocumentService>();
            container.RegisterType<IAnswerService, AnswerService>();
        }
    }
}
