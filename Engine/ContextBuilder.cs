using Selflow.Engine.Abstraction;
using Selflow.Engine.Entities;

namespace Selflow.Engine
{
    public class ContextBuilder
    {
        public static WorkflowContext Build(string workflowCode, object flowData, ISessionProvider sessionProvider, WorkflowDefinition definition)
        {
            return sessionProvider.CurrentWorkflowContext = new WorkflowContext
                                                            {            
                                                                Definition = definition,
                                                                Data = flowData
                                                            };
        }
    }
}