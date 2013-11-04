namespace Selflow.Engine
{
    public interface IWorkflowEngine
    {
        WorkflowResult StartNewInstance(string workflowCode, object flowData);

        WorkflowResult ApproveWorkflow(int flowStateId, string workflowCode, object flowData);

        WorkflowResult RejectWorkflow(int flowStateId, string workflowCode, object flowData);

        WorkflowResult ExecuteCustomWorkflowAction(int flowStateId, string workflowCode, string actionCode, object flowData);

        WorkflowResult CancelWorkflow(int flowStateId, string workflowCode, object flowData);

        WorkflowResult SuspendWorkflow(int flowStateId, string workflowCode, object flowData);

        WorkflowResult ResumeWorkflow(int flowStateId, string workflowCode, object flowData);
    }
}