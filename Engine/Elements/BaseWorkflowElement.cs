using Selflow.Engine.Abstraction;

namespace Selflow.Engine.Elements
{
    public abstract class BaseWorkflowElement : IWorkflowElement
    {
        public string ToElement { get; set; }

        public IElementCondition ElementCondition { get; set; }
    }
}