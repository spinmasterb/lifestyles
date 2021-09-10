using System;
using System.Web.Mvc;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Lifestyles.Windsor;

namespace Lifestyles.App_Start
{
    public class ContainerBootstrapper : IContainerAccessor, IDisposable
    {
        private readonly IWindsorContainer _container;

        ContainerBootstrapper(IWindsorContainer container)
        {
            _container = container;
        }

        public IWindsorContainer Container => _container;

        public static ContainerBootstrapper Bootstrap()
        {
            var container = new WindsorContainer()
                .Install(FromAssembly.This());

            var resolver = new WindsorDependencyResolver(container);
            DependencyResolver.SetResolver(resolver);

            return new ContainerBootstrapper(container);
        }

        public void Dispose()
        {
            _container.Dispose();
        }
    }
}