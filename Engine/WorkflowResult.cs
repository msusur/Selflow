namespace Selflow.Engine
{
    public class WorkflowResult : IWorkflowResult
    {
        public int WorkflowInstanceId { get; set; }

        public int WorkflowStateId { get; set; }

        public object FlowData { get; set; }
    }
}