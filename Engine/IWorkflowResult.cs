namespace Selflow.Engine
{
    public interface IWorkflowResult
    {
        int WorkflowInstanceId { get; set; }

        int WorkflowStateId { get; set; }

        object FlowData { get; set; }
    }
}