namespace Selflow.Engine
{
    public interface ISessionProvider
    {
        WorkflowContext CurrentWorkflowContext { get; set; }
    }
}