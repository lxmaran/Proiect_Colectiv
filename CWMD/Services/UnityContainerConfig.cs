﻿using Contracts.IServices;
using Dal;
using Microsoft.Practices.Unity;
using Services.Services;

namespace Services
{
    public static class UnityContainerConfig
    {
        public static void Configure(IUnityContainer container)
        {
            //regiseter your services like:
            //container.RegisterType<IServiceInterface, ServiceImpl>();
            container.RegisterType<IMyDbContext, MyDbContext>();
        }
    }
}
