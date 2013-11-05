using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Selflow.Engine.Abstraction;
using Selflow.Engine.Elements;
using Selflow.Engine.Entities;
using Selflow.Engine.Exceptions;

namespace Selflow.Engine
{
    public class WorkflowEngine : IWorkflowEngine
    {
        private readonly IWorkflowRepository _flowRepository;
        private readonly ISessionProvider _sessionProvider;
        private readonly IWorkflowExecutionHelper _executionHelper;
        private readonly IRuleEngine _ruleEngine;

        public WorkflowEngine(IWorkflowRepository flowRepository, ISessionProvider sessionProvider, IWorkflowExecutionHelper executionHelper, IRuleEngine ruleEngine)
        {
            _flowRepository = flowRepository;
            _sessionProvider = sessionProvider;
            _executionHelper = executionHelper;
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

            WorkflowStatus status = _executionHelper.ExecuteElement(context);

            _flowRepository.SaveStatus(status);

            return ResultBuilder.BuildResult(context, status);
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

    public interface IWorkflowExecutionHelper
    {
        WorkflowStatus ExecuteElement(WorkflowContext context);
    }
}