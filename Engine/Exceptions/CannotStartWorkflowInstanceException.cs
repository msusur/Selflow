using System;

namespace Selflow.Engine.Exceptions
{
    public class CannotStartWorkflowInstanceException : Exception
    {
        public CannotStartWorkflowInstanceException(string message)
            : base(message)
        { }
    }
}