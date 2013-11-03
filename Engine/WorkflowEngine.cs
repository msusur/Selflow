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

        public IWorkflowResult StartNewInstance(string workflowCode, object flowData)
        {
            throw new System.NotImplementedException();
        }

        public IWorkflowResult ApproveWorkflow(string workflowCode, object flowData)
        {
            throw new System.NotImplementedException();
        }

        public IWorkflowResult RejectWorkflow(string workflowCode, object flowData)
        {
            throw new System.NotImplementedException();
        }

        public IWorkflowResult ExecuteCustomWorkflowAction(string workflowCode, string actionCode, object flowData)
        {
            throw new System.NotImplementedException();
        }

        public IWorkflowResult CancelWorkflow(string workflowCode, object flowData)
        {
            throw new System.NotImplementedException();
        }

        public IWorkflowResult SuspendWorkflow(string workflowCode, object flowData)
        {
            throw new System.NotImplementedException();
        }

        public IWorkflowResult ResumeWorkflow(string workflowCode, object flowData)
        {
            throw new System.NotImplementedException();
        }
    }
}