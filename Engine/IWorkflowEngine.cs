namespace Selflow.Engine
{
    public interface IWorkflowEngine
    {
        IWorkflowResult StartNewInstance(string workflowCode, object flowData);

        IWorkflowResult ApproveWorkflow(string workflowCode, object flowData);
        
        IWorkflowResult RejectWorkflow(string workflowCode, object flowData);

        IWorkflowResult ExecuteCustomWorkflowAction(string workflowCode, string actionCode, object flowData);

        IWorkflowResult CancelWorkflow(string workflowCode, object flowData);
        
        IWorkflowResult SuspendWorkflow(string workflowCode, object flowData);
        
        IWorkflowResult ResumeWorkflow(string workflowCode, object flowData);
    }
}