namespace Selflow.Engine
{
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