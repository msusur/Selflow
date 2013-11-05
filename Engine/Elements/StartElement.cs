using Selflow.Engine.Abstraction;

namespace Selflow.Engine.Elements
{
    public class StartElement : BaseWorkflowElement
    {
        IElementCondition ElementCondition { get; set; }
    }
}