using System.Linq;
using Selflow.Engine.Abstraction;
using Selflow.Engine.Elements;
using Selflow.Engine.Exceptions;

namespace Selflow.Engine
{
    public class WorkflowEngine : IWorkflowEngine
    {
        private readonly IWorkflowRepository _flowRepository;
        private readonly ISessionProvider _sessionProvider;
        private readonly IRuleEngine _ruleEngine;

        public WorkflowEngine(IWorkflowRepository flowRepository, ISessionProvider sessionProvider, IRuleEngine ruleEngine)
        {
            _flowRepository = flowRepository;
            _sessionProvider = sessionProvider;
            _ruleEngine = ruleEngine;
        }

        public WorkflowResult StartNewInstance(string workflowCode, object flowData)
        {
            var definition = _flowRepository.GetFlowDefinitionByCode(workflowCode);
            var context = ContextBuilder.Build(workflowCode, flowData, _sessionProvider, definition);


            StartElement startElement = definition
                                            .GetStartingElements()
                                            .FirstOrDefault(element => _ruleEngine.CanExecuteElement(element));
            if (startElement == null)
            {
                throw new CannotStartWorkflowInstanceException("Start element not found.");
            }
            var currentElements = definition.GetElementByIds(startElement.ToElements);

            if (currentElements == null)
            {
                throw new ElementNotFoundException(startElement.ToElements);
            }
            context.CurrentElements = currentElements;
            
            WorkflowStatus status = ExecuteElement(context);

            _flowRepository.SaveStatus(status);

            return ResultBuilder.BuildResult(context, status);
        }

        private static WorkflowStatus ExecuteElement(WorkflowContext context)
        {
            //TODO: recursively traverse the given current elements. All elements should be executed in one time.
            //      So first an execution plan must be calculated then executed at the same time.
            //      this is designed to be genericly runned by the other methods also.
            return new WorkflowStatus(); //returns the current workflow status. Which is all executed elements and paths. 
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

    public class WorkflowStatus
    {
    }
}