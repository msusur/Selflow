using Selflow.Engine.Entities;

namespace Selflow.Engine
{
    public class ResultBuilder
    {
        public static WorkflowResult BuildResult(WorkflowContext context, WorkflowStatus status)
        {
            return new WorkflowResult();
        }
    }
}