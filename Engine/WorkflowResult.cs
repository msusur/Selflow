namespace Selflow.Engine
{
    public class WorkflowResult
    {
        public int WorkflowInstanceId { get; set; }

        public int WorkflowStateId { get; set; }

        public object FlowData { get; set; }
    }
}