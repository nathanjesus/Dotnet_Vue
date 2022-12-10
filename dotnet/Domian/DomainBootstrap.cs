using Unity;
using HallHeroes.Repository;

namespace Domian
{
    public class DomainBootstrap
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            RepositoryBootstrap.RegisterTypes(container);
            container.RegisterType<IDomainApplication, DomainApplication>();
        }
    }
}
