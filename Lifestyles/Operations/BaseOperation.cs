using System;

namespace Lifestyles.Operations
{
    public abstract class BaseOperation : IOperation
    {
        public Guid OperationId { get; set; }

        protected BaseOperation()
        {
            OperationId = Guid.NewGuid();
        }

        public override string ToString()
        {
            return OperationId.ToString();
        }
    }
}