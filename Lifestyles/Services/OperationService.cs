using System;
using System.Web.Mvc;
using Lifestyles.Operations;

namespace Lifestyles.Services
{
    public class OperationService : IOperationService
    {
        //public ITransientOperation Transient { get; } = DependencyResolver.Current.GetService<ITransientOperation>();
        //public IPerWebRequestOperation PerWebRequest { get; } = DependencyResolver.Current.GetService<IPerWebRequestOperation>();

        public ITransientOperation Transient { get; set; }
        public IPerWebRequestOperation PerWebRequest { get; set; }

        public OperationService(ITransientOperation transientOperation, IPerWebRequestOperation perWebRequestOperation)
        {
            Transient = transientOperation;
            PerWebRequest = perWebRequestOperation;
        }
    }
}