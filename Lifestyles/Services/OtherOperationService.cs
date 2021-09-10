using System;
using Lifestyles.Operations;

namespace Lifestyles.Services
{
    public class OtherOperationService : OperationService, IOtherOperationService
    {
        public OtherOperationService(ITransientOperation transientOperation, IPerWebRequestOperation perWebRequestOperation) : base(transientOperation, perWebRequestOperation)
        {
        }
    }
}