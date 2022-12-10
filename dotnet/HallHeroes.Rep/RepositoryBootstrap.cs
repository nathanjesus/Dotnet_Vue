using Unity;

namespace HallHeroes.Repository
{
    public class RepositoryBootstrap
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IUnitOfWork, UnitOfWork>();
        }
    }
}
