using Selflow.Engine.Entities;

namespace Selflow.Engine.Abstraction
{
    public interface ISessionProvider
    {
        WorkflowContext CurrentWorkflowContext { get; set; }
    }
}