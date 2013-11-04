namespace Selflow.Engine
{
    public class WorkflowEngine : IWorkflowEngine
    {
        private readonly IWorkflowRepository _flowRepository;
        private readonly ISessionProvider _sessionProvider;

        public WorkflowEngine(IWorkflowRepository flowRepository, ISessionProvider sessionProvider)
        {
            _flowRepository = flowRepository;
            _sessionProvider = sessionProvider;
        }

        public WorkflowResult StartNewInstance(string workflowCode, object flowData)
        {
            WorkflowDefinition definition = _flowRepository.GetFlowDefinitionByCode(workflowCode);
            WorkflowContext context = ContextBuilder.Build(workflowCode, flowData, _sessionProvider, definition);

            return ResultBuilder.BuildResult(context);
        }

        public WorkflowResult ApproveWorkflow(int flowStateId, string workflowCode, object flowData)
        {
            throw new System.NotImplementedException();
        }

        public WorkflowResult RejectWorkflow(int flowStateId, string workflowCode, object flowData)
        {
            throw new System.NotImplementedException();
        }

        public WorkflowResult ExecuteCustomWorkflowAction(int flowStateId, string workflowCode, string actionCode, object flowData)
        {
            throw new System.NotImplementedException();
        }

        public WorkflowResult CancelWorkflow(int flowStateId, string workflowCode, object flowData)
        {
            throw new System.NotImplementedException();
        }

        public WorkflowResult SuspendWorkflow(int flowStateId, string workflowCode, object flowData)
        {
            throw new System.NotImplementedException();
        }

        public WorkflowResult ResumeWorkflow(int flowStateId, string workflowCode, object flowData)
        {
            throw new System.NotImplementedException();
        }
    }
}