namespace Selflow.Engine
{
    public interface IWorkflowRepository
    {
        WorkflowDefinition GetFlowDefinitionByCode(string workflowCode);
    }
}