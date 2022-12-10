using System.Linq;
using System.Web.Mvc;
using Unity.AspNet.Mvc;


[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(HallHeroes.Config.UnityActivator), nameof(HallHeroes.Config.UnityActivator.Start))]
[assembly: WebActivatorEx.ApplicationShutdownMethod(typeof(HallHeroes.Config.UnityActivator), nameof(HallHeroes.Config.UnityActivator.Shutdown))]
namespace HallHeroes.Config
{
    public static class UnityActivator
    {
        
        public static void Start()
        {
            FilterProviders.Providers.Remove(FilterProviders.Providers.OfType<FilterAttributeFilterProvider>().First());
            FilterProviders.Providers.Add(new UnityFilterAttributeFilterProvider(UnityConfig.Container));
            DependencyResolver.SetResolver(new UnityDependencyResolver(UnityConfig.Container));

        }

        public static void Shutdown()
        {
            UnityConfig.Container.Dispose();
        }
    }
}
