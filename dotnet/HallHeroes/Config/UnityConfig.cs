using Domian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unity;

namespace HallHeroes.Config
{
    public static class UnityConfig
    {
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });  
        public static IUnityContainer Container => container.Value;
        public static void RegisterTypes(IUnityContainer container)
        {
            DomainBootstrap.RegisterTypes(container);
        }
    }
}
