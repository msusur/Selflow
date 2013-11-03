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
            WorkflowDefinition definition = _flowRepository.GetFlowDefinitionByCode(workflowCode);
            WorkflowContext context = ContextBuilder.Build(workflowCode, flowData, _sessionProvider, definition);
            throw new System.NotImplementedException();
        }

        public IWorkflowResult ApproveWorkflow(int flowStateId, string workflowCode, object flowData)
        {
            throw new System.NotImplementedException();
        }

        public IWorkflowResult RejectWorkflow(int flowStateId, string workflowCode, object flowData)
        {
            throw new System.NotImplementedException();
        }

        public IWorkflowResult ExecuteCustomWorkflowAction(int flowStateId, string workflowCode, string actionCode, object flowData)
        {
            throw new System.NotImplementedException();
        }

        public IWorkflowResult CancelWorkflow(int flowStateId, string workflowCode, object flowData)
        {
            throw new System.NotImplementedException();
        }

        public IWorkflowResult SuspendWorkflow(int flowStateId, string workflowCode, object flowData)
        {
            throw new System.NotImplementedException();
        }

        public IWorkflowResult ResumeWorkflow(int flowStateId, string workflowCode, object flowData)
        {
            throw new System.NotImplementedException();
        }
    }

    public class WorkflowDefinition
    {
    }

    public class WorkflowContext
    {
    }

    public class ContextBuilder
    {
        public static WorkflowContext Build(string workflowCode, object flowData, ISessionProvider sessionProvider, WorkflowDefinition definition)
        {
            return sessionProvider.CurrentWorkflowContext = new WorkflowContext
                   {
            
                   };
        }
    }
}