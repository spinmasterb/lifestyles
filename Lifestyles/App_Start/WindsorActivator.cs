using System;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(Lifestyles.App_Start.WindsorActivator), "PreStart")]
[assembly: ApplicationShutdownMethod(typeof(Lifestyles.App_Start.WindsorActivator), "Shutdown")]

namespace Lifestyles.App_Start
{
    public class WindsorActivator
    {
        static ContainerBootstrapper _bootstrapper;

        public static void PreStart()
        {
            _bootstrapper = ContainerBootstrapper.Bootstrap();
        }

        public static void Shutdown()
        {
            _bootstrapper?.Dispose();
        }
    }
}