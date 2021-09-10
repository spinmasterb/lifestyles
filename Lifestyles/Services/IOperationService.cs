using System;
using Lifestyles.Operations;

namespace Lifestyles.Services
{
    public interface IOperationService
    {
        ITransientOperation Transient { get; }
        IPerWebRequestOperation PerWebRequest { get; }
    }
}
