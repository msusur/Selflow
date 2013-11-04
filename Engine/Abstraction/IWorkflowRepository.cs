namespace Selflow.Engine.Abstraction
{
    public interface IWorkflowRepository
    {
        WorkflowDefinition GetFlowDefinitionByCode(string workflowCode);
    }
}