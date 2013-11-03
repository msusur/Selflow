namespace Selflow.Engine
{
    public interface IWorkflowEngine
    {
        IWorkflowResult StartNewInstance(string workflowCode, object flowData);

        IWorkflowResult ApproveWorkflow(int flowStateId, string workflowCode, object flowData);

        IWorkflowResult RejectWorkflow(int flowStateId, string workflowCode, object flowData);

        IWorkflowResult ExecuteCustomWorkflowAction(int flowStateId, string workflowCode, string actionCode, object flowData);

        IWorkflowResult CancelWorkflow(int flowStateId, string workflowCode, object flowData);

        IWorkflowResult SuspendWorkflow(int flowStateId, string workflowCode, object flowData);

        IWorkflowResult ResumeWorkflow(int flowStateId, string workflowCode, object flowData);
    }
}