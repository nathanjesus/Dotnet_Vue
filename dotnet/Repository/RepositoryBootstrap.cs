using System;
using System.Collections.Generic;
using System.Text;
using Unity;

namespace Repository
{
    public class RepositoryBootstrap
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IUnitOfWork, UnitOfWork>();
        }
    }
}
