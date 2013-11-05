using Selflow.Engine.Entities;

namespace Selflow.Engine.Abstraction
{
    public interface IWorkflowRepository
    {
        WorkflowDefinition GetFlowDefinitionByCode(string workflowCode);
        void SaveStatus(WorkflowStatus status);
    }
}