namespace Selflow.Engine.Abstraction
{
    public interface IWorkflowElement
    {
        string ToElement { get; set; }
        IElementCondition ElementCondition { get; set; }
        string ElementCode { get; set; }
    }

    public interface IElementCondition
    {
    }
}