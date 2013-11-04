namespace Selflow.Engine.Abstraction
{
    public interface ISessionProvider
    {
        WorkflowContext CurrentWorkflowContext { get; set; }
    }
}