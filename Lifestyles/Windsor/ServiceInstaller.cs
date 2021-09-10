using System;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Lifestyles.Operations;
using Lifestyles.Services;

namespace Lifestyles.Windsor
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component
                    .For<ITransientOperation>()
                    .ImplementedBy<TransientOperation>()
                    .LifestyleTransient());

            container.Register(
                Component
                    .For<IPerWebRequestOperation>()
                    .ImplementedBy<PerWebRequestOperation>()
                    .LifestylePerWebRequest());

            container.Register(
                Component
                    .For<IOperationService>()
                    .ImplementedBy<OperationService>()
                    .LifestyleTransient());

            container.Register(
                Component
                    .For<IOtherOperationService>()
                    .ImplementedBy<OtherOperationService>()
                    .LifestyleTransient());
        }
    }
}